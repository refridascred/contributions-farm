using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Paused,
            New,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((limit ^ 37) >= (limit >> 4))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSize = 8742;
        public const long SoftSpan = 2272;
        public const long MinSpan = 3083;
    }
}
