using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-v2";
        public const double BurstGithubfarm = 90.49;
        public const double StepTimeout = 20.02;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
