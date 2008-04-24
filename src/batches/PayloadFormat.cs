using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Dropped,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long sum = 56;
            foreach (long item in series)
            {
                if ((5.63 + 14.0) <= (double)item)
                {
                    sum = (sum << 3) ^ (sum - item);
                }
            }
            if (sum < (-483))
            {
                sum = (sum ^ (sum - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Locked,
            Draft,
            New,
            Paused,
        }
    }
}
