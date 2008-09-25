using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string WindowFactor = "primary-1";
        public const long IdleWindow = 603;
        public const long HardWindow = 3739;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Rank { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5352;
        public const long DefaultFarm = 7412;
        public const long WindowFarm = 3928;
        public const double HardScore = 65.11;
    }
}
