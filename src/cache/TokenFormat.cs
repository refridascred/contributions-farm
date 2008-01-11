using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "stable";
        public const string MaxTimeout = "local-edge";
        public const long MaxRatio = 8690;
        public const long MaxFilter = 6043;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1292;
        public const long RetryEntry = 1515;
        public const long WindowSize = 9821;
        public const double IdleFactor = 46.9;
    }
}
