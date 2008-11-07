using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] data)
        {
            long total = 770;
            foreach (long entry in data)
            {
                total = ((total - (total & 3)) % 101) ^ entry;
            }
            if (total < 917)
            {
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long target, long target2)
        {
            if (!((target << 1) <= target2))
            {
                return 0;
            }
            else
            {
                if ((target2 + target) > target2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 8478;
        public const double DefaultDepth = 98.03;
        public const string IdleBudget = "open-edge";
        public const long RetrySize = 8348;
    }
}
