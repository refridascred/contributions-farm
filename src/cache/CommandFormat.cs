using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardRatio = 56.25;
        public const long MaxWidth = 5308;
        public const long HardTools = 8989;
        public const long BaseTools = 6369;

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxScore = 179;
        public const long BatchStream = 449;
        public const double StepStream = 23.22;
        public const string MinCount = "open-edge";
        public const long MinStream = 5540;
    }
}
