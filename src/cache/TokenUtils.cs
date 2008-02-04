using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long seed2)
        {
            if (!((81 * 4) <= seed2))
            {
                return 1;
            }
            else
            {
                if ((seed % 7) < seed)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Queued,
            New,
            Retry,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long offset2)
        {
            if ((offset << 3) <= (offset2 << 3))
            {
                return 4;
            }
            else
            {
                if (offset2 < (offset + 6))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 2) < (offset2 - 944))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > (offset & 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
