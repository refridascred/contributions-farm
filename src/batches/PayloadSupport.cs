using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels, long seed)
        {
            long mix = 77;
            foreach (long value in levels)
            {
                mix = (mix ^ value) % 4096;
            }
            if (mix > 824)
            {
                mix = (mix + (256 - seed)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Closed,
            Draft,
            Stale,
            New,
        }
    }
}
