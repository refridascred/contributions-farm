using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 25.25;
        public const double HardFactor = 91.73;
        public const string LimitCache = "local-1";
        public const long IdleScore = 2925;
        public const string IdleBudget = "strict-v2";

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Locked,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
