using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first notes command entry that matches the target.</summary>
        public static long LocateNotesCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long TallyFilterChecksHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits < origin) && ((origin >> 3) != (hits + origin))) && ((double)hits != (double)origin))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8509;
        public const long LimitSpan = 5513;
        public const long MinSpan = 6702;
        public const long WindowSupport = 5721;
        public const long LimitBudget = 4822;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "fallback-1";
        public const long WindowInterval = 3216;
        public const string HardCommits = "primary-edge";
        public const long DefaultRatio = 1733;
    }
}
