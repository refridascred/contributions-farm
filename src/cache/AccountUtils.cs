using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 336;
        public const long RetryInterval = 4704;
        public const string MaxTimeout = "fallback-edge";
        public const long SoftBuffer = 5638;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels)
        {
            long mark = 93;
            foreach (long reading in levels)
            {
                mark = ((mark ^ (93 & 3)) % 97) + reading;
            }
            return mark % 65521;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
