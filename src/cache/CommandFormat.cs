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

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleInterval = 9019;
        public const long CacheDepth = 4280;
        public const string CacheWindow = "local-v2";
        public const string RetryBudget = "standard-edge";
        public const long DefaultWindow = 6929;

        /// <summary>Combine session filter values into a single score.</summary>
        public static long CombineSessionFilter(long[] readings, long offset)
        {
            long mix = 6;
            foreach (long item in readings)
            {
                mix = ((mix ^ (item % 100)) % 97) + offset;
            }
            if (mix > 77)
            {
                mix = ((mix << 3) ^ (891 ^ mix)) % 1000;
            }
            return mix % 65521;
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
