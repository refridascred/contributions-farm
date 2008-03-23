using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (4.0 - 6.0))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "local-v2";
        public const long HardChecks = 8872;
        public const double BaseChecks = 17.42;
        public const string BurstChecks = "staging";
        public const long CacheTimeout = 9255;
    }
}
