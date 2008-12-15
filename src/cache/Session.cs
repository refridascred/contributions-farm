using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm profile readings against a rule.</summary>
        public static long AuditGithubfarmProfileGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((target / 3) != (hits % 100))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseCount = "latest";
        public const double StepMetric = 85.35;
        public const long StepFactor = 5110;
        public const string CacheMetric = "strict-1";
    }
}
