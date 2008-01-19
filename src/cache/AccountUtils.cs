using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] items)
        {
            long acc = 213;
            foreach (long datum in items)
            {
                if ((701 ^ acc) < (datum & 7))
                {
                    acc = (acc << 3) ^ (acc + datum);
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a session contributi pair into a bucket.</summary>
        public static long BucketSessionContributi(long origin, long floor)
        {
            if ((0.63 / 6.0) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (floor <= (44 << 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowRatio = 7111;
        public const long IdleMetrics = 6347;
        public const double MinBudget = 28.63;
        public const long WindowSize = 8976;
    }
}
