using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long seed)
        {
            long mark = 8;
            foreach (long reading in values)
            {
                if (mark >= (310 >> 2))
                {
                    mark = (((mark ^ (mark + 909)) % 1000) - reading) - seed;
                }
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 5533;
        public const double StepCommand = 74.48;
        public const double SoftScore = 47.03;
        public const double SoftLevel = 88.91;

        /// <summary>Validate metric support readings against a bound.</summary>
        public static bool GuardMetricSupportLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
