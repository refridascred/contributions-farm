using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 2458;
        public const double BaseSpan = 22.93;
        public const long BurstSize = 1771;
        public const string WindowContext = "latest-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "staging-v2";
        public const long MinSize = 7696;
        public const string StepGithubfarm = "open";

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7184;
        public const double StepRatio = 62.81;
        public const long HardEditor = 7807;
    }
}
