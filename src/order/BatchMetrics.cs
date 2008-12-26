using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor batch value against two limits.</summary>
        public static long RankEditorBatch(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((limit2 & 1) <= bound)
            {
                return 8;
            }
            else
            {
                if ((limit + limit2) > (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 + bound) >= (limit2 >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound << 1) < bound) || ((double)limit2 >= (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            if (((7.18 * 6.0) < (double)bound) && (bound <= (47 >> 4)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) >= bound2)
                {
                    return 1;
                }
                else
                {
                    if ((4.3 * 6.9) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 ^ 5) != (bound2 - bound2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm commits readings against a rule.</summary>
        public static long CountFarmCommitsOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((0 + seen) <= seen) || ((3 + target) < seen)))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRatio = 49.98;
        public const long IdleCount = 1920;
        public const double DefaultRatio = 17.05;
        public const long MaxLevel = 8216;
        public const string SoftRoute = "fallback-edge";

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Locked,
            Done,
        }
    }
}
