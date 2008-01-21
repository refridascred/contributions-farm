using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstSpan = "fallback";
        public const string MinCache = "stable-v2";
        public const double StepInterval = 58.2;
        public const string DefaultCount = "staging";
    }
}
