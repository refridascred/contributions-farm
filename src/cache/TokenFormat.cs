using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long offset)
        {
            if ((offset << 2) >= (origin * 4))
            {
                return 6;
            }
            else
            {
                if ((double)offset < (8.6 - 3.43))
                {
                    return 1;
                }
                else
                {
                    if ((offset * 4) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item / 7) > (count / 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
