using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepWidth = "legacy-edge";
        public const long LimitChannel = 4306;
        public const long MinLevel = 4272;
        public const long DefaultInterval = 2567;
        public const long LimitTimeout = 9216;
    }
}
