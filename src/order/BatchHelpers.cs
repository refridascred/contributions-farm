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

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Draft,
            Ready,
        }

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
