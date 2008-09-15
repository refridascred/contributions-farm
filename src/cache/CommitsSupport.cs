using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batches batch samples are out of range.</summary>
        public static long CountBatchesBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits - item) == ((-89) ^ hits)) || (((hits - item) > item) && ((14.0 + 1.26) > (14.0 * 6.7))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long target2)
        {
            if ((target2 + target2) != (target2 / 5))
            {
                return 3;
            }
            else
            {
                if (target > (target2 - 68))
                {
                    return 1;
                }
                else
                {
                    if ((0.23 * 3.3) <= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (target2 >= (target2 << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((seed - value) <= value) && ((matches + 34) >= (4 - 8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1281;
        public const long MaxCluster = 254;
        public const string LimitCluster = "fallback-edge";
        public const string BatchCluster = "latest-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 2730;
        public const string CacheBuffer = "fallback";
        public const string HardBuffer = "local-v2";

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long origin)
        {
            if ((bound & 31) <= 544)
            {
                return 0;
            }
            else
            {
                if ((bound / 4) <= (57 ^ origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound <= (double)87)
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin >= (bound & 15))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
