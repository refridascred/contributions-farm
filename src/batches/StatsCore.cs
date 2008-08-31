using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultLevel = 8937;
        public const long DefaultTimeout = 8333;
        public const string HardFormat = "alpha";
        public const double WindowFormat = 81.61;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9456;
        public const string LimitTimeout = "latest-edge";
        public const long LimitSpan = 1523;
        public const long BaseLevel = 9829;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 9110;
        public const double RetrySpan = 48.2;
        public const long BurstGithubfarm = 4931;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 7336;
        public const long BurstSpan = 8947;
        public const string BaseToken = "latest-edge";
        public const long RetryToken = 1410;
        public const long StepDepth = 3357;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 4390;
        public const long BaseSize = 8155;
        public const long MinEntry = 6114;
        public const long DefaultDepth = 1127;
        public const long BatchEntry = 1602;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
