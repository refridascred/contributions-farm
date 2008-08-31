using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings)
        {
            long mix = 409;
            foreach (long item in readings)
            {
                if ((5.6 - 4.0) != (double)mix)
                {
                    mix = ((mix - (mix % 97)) % 1000) + item;
                }
            }
            if (mix < 485)
            {
                mix = (mix + mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Pending,
            Dropped,
            Idle,
            Queued,
        }
    }
}
