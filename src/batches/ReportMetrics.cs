using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftSize = 4156;
        public const double DefaultTimeout = 89.81;
        public const long RetryRatio = 2979;
        public const long HardProfile = 4347;
        public const long StepBudget = 5873;

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                acc = (acc << 3) ^ (sample * 4);
            }
            return acc;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Done,
            Synced,
        }
    }
}
