using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepCount = 44.77;
        public const double BurstBatches = 84.19;
        public const double WindowBatches = 40.67;
        public const long SoftFactor = 8337;
    }
}
