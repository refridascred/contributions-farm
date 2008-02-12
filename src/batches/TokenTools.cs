using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleLevel = 4873;
        public const double MinBudget = 26.5;
        public const long BurstScore = 8744;
        public const long BaseCache = 791;
        public const long WindowCache = 1787;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
