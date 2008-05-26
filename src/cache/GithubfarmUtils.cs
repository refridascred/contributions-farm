using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (bound >= (634 * 5))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
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
