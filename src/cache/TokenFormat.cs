using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a entry order counter forward.</summary>
        public static long SeriesEntryOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Locked,
            Dropped,
            Paused,
        }
    }
}
