using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxScore = "primary-edge";
        public const long RetryDepth = 2056;
        public const long BatchRecord = 9506;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((gap * 4) > offset)
            {
                return 4;
            }
            else
            {
                if ((17.0 * 0.3) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((13 + floor) <= (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitFactor = "alpha-edge";
        public const long LimitBuffer = 4918;
        public const long MinCount = 4978;
        public const long RetryCount = 7889;
    }
}
