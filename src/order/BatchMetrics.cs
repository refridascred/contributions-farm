using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((64 - matches) > 278)
                {
                    matches = ((matches + 1) + datum) + step;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 77.18;
        public const long HardBudget = 463;
        public const long MinWidth = 8874;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultDepth = 62.74;
        public const long BurstGithubfarm = 6724;
        public const long StepTimeout = 7862;
        public const long StepGithubfarm = 2343;
        public const string RetryGithubfarm = "local-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstDepth = 1008;
        public const long StepReport = 4509;
        public const string MinReport = "local-edge";
        public const long RetryReport = 1609;

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
