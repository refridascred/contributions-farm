using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long total = 549;
            foreach (long sample in samples)
            {
                if (((double)total >= (double)sample) && ((3.5 + 1.0) < (double)sample))
                {
                    total = (total ^ (total * 4)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Synced,
            Draft,
            New,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 906;
        public const long RetryMetrics = 2109;
        public const double MinMetrics = 60.31;
        public const long IdleMetrics = 2250;
    }
}
