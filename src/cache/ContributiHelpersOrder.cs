using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "cached";
        public const long SoftOrder = 7104;
        public const long LimitDepth = 9771;
        public const double BaseFactor = 41.38;

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                long count = (20 ^ 3) + (seed & 1);
                mark = mark ^ count;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
