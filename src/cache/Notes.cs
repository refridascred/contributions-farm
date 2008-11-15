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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinScore = 635;
        public const long BatchSize = 4583;
        public const long BatchCluster = 6938;
        public const string BurstTimeout = "fallback-edge";
        public const long BaseCluster = 1438;

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1445;
        public const double BatchEditor = 56.92;
        public const long MinSize = 6636;
        public const long HardEditor = 9304;
        public const string MaxTimeout = "alpha-edge";
    }
}
