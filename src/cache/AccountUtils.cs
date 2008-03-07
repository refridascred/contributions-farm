using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a githubfarm graph pair into a bucket.</summary>
        public static long BucketGithubfarmGraph(long seed, long offset)
        {
            if (!((seed + seed) >= (offset & 255)))
            {
                return 8;
            }
            else
            {
                if (!(0.3 >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (seed <= (offset + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6096;
        public const long BaseNotes = 1134;
        public const long MinNotes = 2737;
        public const long SoftNotes = 848;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 867;
        public const long MinCache = 9764;
        public const long RetryCache = 8676;
        public const string LimitTimeout = "cached-1";
        public const long CacheInterval = 605;
    }
}
