using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Done,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the queue layout entries that pass the check.</summary>
        public static long MeasureQueueLayoutMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample <= (seen >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Closed,
            Stale,
            Retry,
        }
    }
}
