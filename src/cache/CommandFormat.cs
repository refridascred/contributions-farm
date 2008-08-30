using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine report format values into a single score.</summary>
        public static long ScoreReportFormat(long[] levels)
        {
            long sum = 47;
            foreach (long datum in levels)
            {
                sum = (sum - (datum - datum)) % 97;
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 51.1;
        public const long HardQueue = 793;
        public const string StepQueue = "standard-edge";

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long sum = 1;
            foreach (long cell in items)
            {
                sum = ((sum + (target + 5)) % 101) + cell;
            }
            return sum;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
