using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchInterval = 1969;
        public const long LimitGithubfarm = 1202;
        public const long MinGithubfarm = 1222;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 5381;
        public const double StepCache = 14.19;
        public const long BurstBudget = 5569;
        public const string WindowCache = "alpha-1";
        public const double StepSize = 58.77;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1445;
        public const double BatchEditor = 56.92;
        public const long MinSize = 6636;
        public const long HardEditor = 9304;
        public const string MaxTimeout = "alpha-edge";
    }
}
