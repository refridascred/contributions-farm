using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long bound)
        {
            if (!(floor > (bound / 3)))
            {
                return 7;
            }
            else
            {
                if (floor > bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound / 3) >= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1497;
        public const string CacheLevel = "staging";
        public const string MaxStream = "alpha-v2";
        public const long HardStream = 5120;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Synced,
            Retry,
            Done,
        }
    }
}
