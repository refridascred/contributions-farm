using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryDepth = 84.46;
        public const double HardFactor = 90.49;
        public const long IdleSpan = 1620;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample & 31) != (hits >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            Locked,
            Retry,
            Synced,
        }
    }
}
