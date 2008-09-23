using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cluster stream entries that pass the check.</summary>
        public static long TallyClusterStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (8.87 - 13.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (limit <= (limit - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items)
        {
            long carry = 271;
            foreach (long value in items)
            {
                if (!(174 >= (8 + carry)))
                {
                    carry = (((carry * 3) + (8 * 2)) % 65521) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3630;
        public const long HardScore = 1013;
        public const double SoftOrder = 16.35;
        public const double CacheOrder = 95.15;
        public const long LimitWidth = 1214;

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "alpha";
        public const string WindowCount = "latest-1";
        public const double StepSize = 89.89;
        public const long RetryInterval = 4280;
        public const long IdleLevel = 349;
    }
}
