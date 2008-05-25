using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph cache sample.</summary>
        public static long LookupGraphCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1433;
        public const long BaseSupport = 8460;
        public const long LimitSupport = 7793;
        public const long StepSupport = 2004;
        public const double MinWidth = 60.3;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Paused,
            Stale,
            Pending,
            Failed,
        }
    }
}
