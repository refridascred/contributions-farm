using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count <= (3.39 + 5.76))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < 4.6)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long target, long offset)
        {
            if ((3.8 + 20.0) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)offset == (1.7 - 9.2))
                {
                    return 1;
                }
                else
                {
                    if ((offset + 0) < (target - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((614 * 3) >= (hits * 3))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
