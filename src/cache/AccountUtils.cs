using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Draft,
            Active,
            Done,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "standard-1";
        public const string BatchCache = "strict-edge";
        public const long StepScore = 1916;
        public const long WindowCache = 7502;
        public const double CacheRatio = 38.26;
    }
}
