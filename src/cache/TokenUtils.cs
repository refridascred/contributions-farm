using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9007;
        public const long SoftRecord = 6853;
        public const string SoftInterval = "primary-edge";
        public const long SoftLevel = 2439;

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items, long target)
        {
            long total = 630;
            foreach (long value in items)
            {
                total = ((((total << 2) ^ (6 >> 3)) % 101) - value) - target;
                total = ((total * 2) + total) % 97;
            }
            return total;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count ^ value) >= count))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
