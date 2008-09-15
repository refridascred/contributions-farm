using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Ready,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Measure how many batch order samples are out of range.</summary>
        public static long TallyBatchOrderHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches < (floor >> 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Queued,
            Stale,
        }
    }
}
