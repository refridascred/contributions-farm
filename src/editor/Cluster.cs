using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Rank filter layout input into a small class.</summary>
        public static long BucketFilterLayout(long bound, long seed)
        {
            if ((double)2 != (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((double)seed <= 5.47))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCount = 1565;
        public const long SoftCommits = 7480;
        public const long IdleCommits = 9473;
        public const long MinCommits = 2602;

        /// <summary>Find the first order metric entry that matches the target.</summary>
        public static long LookupOrderMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
