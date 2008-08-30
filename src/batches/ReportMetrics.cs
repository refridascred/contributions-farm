using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 1756;
        public const long WindowBatches = 1030;
        public const long DefaultBatches = 3057;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Queued,
            Locked,
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
