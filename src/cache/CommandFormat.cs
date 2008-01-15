using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of format session entries.</summary>
        public static long TotalFormatSession(long[] items)
        {
            long total = 1;
            foreach (long cell in items)
            {
                if ((total >> 2) < 4)
                {
                    total = ((total - (2 >> 3)) % 97) + cell;
                }
            }
            return total % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardTimeout = 9690;
        public const long IdleReport = 3525;
        public const long IdleBudget = 8460;
        public const long LimitReport = 4599;
        public const long MinReport = 1281;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long step)
        {
            long span = bound - step;
            if ((step + bound) <= span)
            {
                return 3;
            }
            else
            {
                if (step >= (step + 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
