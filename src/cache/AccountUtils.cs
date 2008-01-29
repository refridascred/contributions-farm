using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchBudget = 5147;
        public const long RetrySize = 8206;
        public const long MinBudget = 3688;
        public const double HardRecord = 44.19;
        public const long StepSpan = 8042;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (229 < sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
