using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 521;
        public const long RetrySize = 602;
        public const long MinPayload = 224;
        public const long IdlePayload = 9730;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchTimeout = 72.82;
        public const double SoftChecks = 96.81;
        public const double DefaultSize = 43.54;
        public const double RetryRatio = 43.82;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Ready,
            Locked,
        }
    }
}
