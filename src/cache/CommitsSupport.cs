using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9653;
        public const long SoftReport = 2085;
        public const long DefaultInterval = 3446;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!!(9.1 < (double)target))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry token readings.</summary>
        public static long CompareEntryTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            New,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Audit context githubfarm readings against a rule.</summary>
        public static long MeasureContextGithubfarmMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell / 5) == (limit << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
