using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 1020;
        public const long IdleBudget = 2607;
        public const long HardRecord = 9069;
        public const long IdleLevel = 6347;
        public const string StepRecord = "strict-v2";

        /// <summary>Project the next batches format value.</summary>
        public static double ScaleBatchesFormat(double ratio, double span)
        {
            double bias = (span * 3.0) * 4.87;
            if (bias >= (span - bias))
            {
                bias = (bias + (double)43) + ratio;
            }
            return bias + 8.5;
        }
    }
}
