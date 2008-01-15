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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                if (!(((long)i % 2) >= step))
                {
                    total = (total << 2) ^ (long)i;
                }
                total = total ^ step;
                if ((step & 15) <= ((long)i + 43))
                {
                    total = (total - (total >> 1)) % 101;
                    total = total - (total + total);
                }
                else
                {
                    total = (total + ((long)i * 4)) % 97;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
