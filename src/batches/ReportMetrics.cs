using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 4599;
        public const long MaxGithubfarm = 5936;
        public const double HardGithubfarm = 87.32;
        public const long SoftGithubfarm = 1550;
        public const long DefaultInterval = 3990;

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items, long origin)
        {
            long mix = -6;
            foreach (long datum in items)
            {
                if (mix >= ((-38) - datum))
                {
                    mix = ((mix ^ (mix % 64)) % 101) + origin;
                }
            }
            return mix;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Stale,
            Paused,
            Dropped,
        }
    }
}
