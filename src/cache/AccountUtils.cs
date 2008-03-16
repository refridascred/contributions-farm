using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (floor > (hits - (long)samples.Length))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
