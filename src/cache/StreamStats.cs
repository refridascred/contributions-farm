using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 4436;
        public const string WindowProfile = "stable-1";
        public const long IdleBudget = 1208;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSize = 7431;
        public const double DefaultStats = 46.8;
        public const double MaxSize = 68.44;
        public const double HardStats = 37.28;
        public const string BaseStats = "primary-v2";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Queued,
            Stale,
        }
    }
}
