using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftFactor = 97.28;
        public const double DefaultContext = 63.77;
        public const long StepWidth = 2589;

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "open";
        public const long IdleWidth = 2936;
        public const string RetryFactor = "standard-v2";
        public const string DefaultFilter = "local-1";
    }
}
