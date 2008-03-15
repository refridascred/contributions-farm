using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 2474;
        public const double StepBatches = 50.5;
        public const long WindowFactor = 3602;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Paused,
            Draft,
        }
    }
}
