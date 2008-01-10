using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 8825;
        public const double WindowDepth = 89.1;
        public const long BaseBudget = 4501;
        public const string CacheBatches = "strict-1";
        public const long StepBatches = 8943;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Locked,
            Done,
            Queued,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
