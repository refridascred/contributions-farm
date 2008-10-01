using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "stable-v2";
        public const long WindowBudget = 2690;
        public const long MinWidth = 8743;
        public const long BaseScore = 7946;
        public const long CacheOrder = 5115;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + origin) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "standard-1";
        public const double BurstChecks = 1.04;
        public const long LimitChecks = 4153;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Pending,
            Dropped,
        }
    }
}
