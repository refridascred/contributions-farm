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

        /// <summary>Check that every editor cluster entry stays within the limit.</summary>
        public static bool CheckEditorClusterLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
