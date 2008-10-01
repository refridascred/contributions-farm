using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleLevel = 8167;
        public const string BurstChecks = "staging-edge";
        public const long DefaultChecks = 4130;

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long origin, long origin2)
        {
            long slot = origin ^ origin2;
            if (!((double)origin == (double)16))
            {
                return 0;
            }
            else
            {
                if ((8.9 - 11.0) >= (double)origin2)
                {
                    return 8;
                }
                else
                {
                    if ((3.3 >= (double)origin) && ((double)origin2 < (double)slot))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((2 > (seen + bound)) || (bound <= datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool GuardAccountEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long origin)
        {
            if (((double)origin > (6.0 + 7.1)) || ((step + origin) <= (772 - origin)))
            {
                return 3;
            }
            else
            {
                if ((origin % 8) > (514 & 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (0.23 - 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 3238;
        public const double CacheRatio = 29.05;
        public const double RetryLayout = 89.26;
        public const long RetryFactor = 3097;
        public const double MaxLayout = 90.49;
    }
}
