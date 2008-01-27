using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long floor)
        {
            long edge = limit + floor;
            if (((double)edge > (double)floor) && ((double)edge >= (17.0 * 9.0)))
            {
                return 2;
            }
            else
            {
                if ((edge % 7) <= (46 % 8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardRatio = 5079;
        public const long IdleCommits = 4682;
        public const string BaseSpan = "latest-v2";
        public const long DefaultLevel = 102;
        public const long RetryCommits = 8786;
    }
}
