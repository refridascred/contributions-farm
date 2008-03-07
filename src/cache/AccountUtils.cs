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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
