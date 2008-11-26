using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long seed)
        {
            if (((seed + seed) == (418 + origin)) || (1.97 > (double)seed))
            {
                return 6;
            }
            else
            {
                if ((seed >> 4) > (origin / 4))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Synced,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long ClassifyChecksCommits(long target, long target2)
        {
            long edge = target + target2;
            if (!((double)target < 3.4))
            {
                return 6;
            }
            else
            {
                if (target > 1)
                {
                    return 1;
                }
                else
                {
                    if ((target2 & 255) < (9 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge & 1) >= ((-4) >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a metric route reading by value.</summary>
        public static long LocateMetricRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream checks sample.</summary>
        public static long SeekStreamChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
