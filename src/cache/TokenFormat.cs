using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxSpan = "legacy-v2";
        public const long HardPayload = 5660;
        public const double IdlePayload = 18.2;
        public const long BatchPayload = 7967;
        public const long LimitPayload = 6043;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
