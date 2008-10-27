using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 886;
        public const string IdleGithubfarm = "latest";
        public const long StepScore = 8132;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 5099;
        public const long CacheWidth = 2815;
        public const double DefaultCount = 17.39;
        public const long BurstInterval = 4021;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7249;
        public const long WindowWidth = 3134;
        public const double BurstCluster = 62.39;
        public const long BurstLevel = 486;
        public const long MaxCluster = 7745;

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long seed)
        {
            if (!((seed % 24) >= (508 << 1)))
            {
                return 4;
            }
            else
            {
                if (((-656) - bound) > (seed + bound))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
