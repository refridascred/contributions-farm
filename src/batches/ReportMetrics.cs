using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepTimeout = 69.98;
        public const string WindowBatches = "staging-v2";
        public const double MinRatio = 48.26;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values)
        {
            long result = 735;
            foreach (long sample in values)
            {
                if (442 > (long)values.Length)
                {
                    result = ((result * 4) + (9 - sample)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Retry,
            Idle,
            Pending,
            Ready,
        }
    }
}
