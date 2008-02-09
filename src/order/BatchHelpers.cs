using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Dropped,
            Idle,
            Closed,
        }
    }
}
