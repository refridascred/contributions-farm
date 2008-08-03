using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 4269;
        public const long SoftCount = 9649;
        public const double MinDepth = 56.55;
        public const long MinStats = 477;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen < 1.4)
                {
                    seen = ((seen + 3) - entry) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long seed)
        {
            long diff = origin ^ seed;
            if ((origin - origin) > origin)
            {
                return 8;
            }
            else
            {
                if (555 < diff)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
