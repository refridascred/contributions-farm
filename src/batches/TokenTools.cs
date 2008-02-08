using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Draft,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 8570;
        public const string SoftCount = "fallback-edge";
        public const double MaxCounter = 50.08;
        public const long MinInterval = 6089;
        public const long StepLevel = 1929;
    }
}
