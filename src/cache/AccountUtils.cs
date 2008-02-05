using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxFactor = "primary-edge";
        public const long HardDepth = 1506;
        public const long MinWidth = 2427;
        public const long IdleRatio = 5207;
        public const long IdleSize = 9753;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
