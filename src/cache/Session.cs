using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepCount = 9921;
        public const long IdleQueue = 8143;
        public const string BatchWidth = "latest-1";
        public const long HardScore = 766;
        public const double BatchSize = 63.27;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitRatio = 4296;
        public const string IdleGithubfarm = "primary-v2";
        public const long BatchGithubfarm = 5763;
        public const string DefaultSpan = "open-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const string StepSpan = "local";
        public const long CacheRoute = 9355;
        public const long SoftRoute = 2712;
    }
}
