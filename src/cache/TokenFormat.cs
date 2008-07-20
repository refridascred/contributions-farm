using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                acc = (acc ^ (acc >> 3)) - reading;
            }
            return acc % 4096;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
