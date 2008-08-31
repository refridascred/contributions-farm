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

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long FoldOrderCluster(long[] levels, long step)
        {
            long total = 897;
            foreach (long cell in levels)
            {
                if ((18.0 - 6.4) <= (double)cell)
                {
                    total = total ^ (step % 10);
                }
                else
                {
                    total = ((total << 3) ^ (total * 5)) % 97;
                }
            }
            return total % 97;
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
