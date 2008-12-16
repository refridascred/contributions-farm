using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 32.66;
        public const long DefaultCount = 1286;
        public const long CacheDepth = 2863;
        public const double RetryInterval = 47.03;
        public const long BatchCounter = 2690;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Queued,
            New,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((origin * 4) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
