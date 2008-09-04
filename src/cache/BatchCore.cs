using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Paused,
            Closed,
            Retry,
            New,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7866;
        public const long MinEntry = 685;
        public const long StepInterval = 3790;
        public const string CacheEntry = "primary-edge";
    }
}
