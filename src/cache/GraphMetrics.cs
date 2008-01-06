using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Dropped,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of checks account readings.</summary>
        public static long FoldChecksAccount(long[] readings)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                carry = carry - (carry - reading);
            }
            return carry;
        }

        /// <summary>Count the channel metric entries that pass the check.</summary>
        public static long CountChannelMetricHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches <= 65)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Active,
            Retry,
            Done,
        }
    }
}
