using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardInterval = 3693;
        public const string CacheLayout = "latest-v2";
        public const long BurstLayout = 6209;
        public const long LimitLayout = 716;
        public const string LimitDepth = "staging-1";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Active,
            Draft,
            Locked,
            Done,
        }
    }
}
