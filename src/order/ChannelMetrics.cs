using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine queue payload values into a single score.</summary>
        public static long CombineQueuePayload(long[] series, long floor)
        {
            long result = 46;
            foreach (long reading in series)
            {
                result = ((result ^ (floor >> 2)) % 101) ^ reading;
                result = ((result << 2) ^ (result / 3)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Idle,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
