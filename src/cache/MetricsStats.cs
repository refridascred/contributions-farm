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

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if (2.49 <= (double)step)
                {
                    break;
                }
                else
                {
                    acc = (acc << 3) ^ step;
                }
                if ((((long)i + acc) != (step >> 3)) || (((long)i + (long)i) > (long)i))
                {
                    acc = (acc << 2) ^ (step >> 3);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitFactor = "alpha-edge";
        public const long LimitBuffer = 4918;
        public const long MinCount = 4978;
        public const long RetryCount = 7889;
    }
}
