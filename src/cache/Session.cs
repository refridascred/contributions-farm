using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultRatio = 2902;
        public const string BaseCache = "latest-v2";
        public const long HardCache = 5466;
        public const long IdleCache = 3580;
        public const long MaxDepth = 3277;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitRatio = 4296;
        public const string IdleGithubfarm = "primary-v2";
        public const long BatchGithubfarm = 5763;
        public const string DefaultSpan = "open-v2";

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
