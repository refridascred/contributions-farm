using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 3380;
        public const long MinLevel = 5750;
        public const long MinFormat = 8132;
        public const long BaseFormat = 655;
        public const double SoftFormat = 58.93;
    }
}
