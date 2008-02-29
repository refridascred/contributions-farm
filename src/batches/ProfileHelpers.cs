using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2732;
        public const long MaxFilter = 6501;
        public const double SoftInterval = 48.7;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((offset ^ floor) < offset)
            {
                return 1;
            }
            else
            {
                if ((offset - 4) >= (offset - floor))
                {
                    return 5;
                }
                else
                {
                    if (!((floor2 % 7) > (782 << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - floor2) > ((-1) + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long origin)
        {
            if ((origin * 5) != (origin * 4))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 6;
                }
                else
                {
                    if (((seed & 31) < (seed << 3)) && ((origin ^ seed) >= (seed * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((16 % 97) <= (matches + matches)) && !(38 <= (entry % 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
