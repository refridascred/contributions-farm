using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 87.57;
        public const double RetryBudget = 93.16;
        public const long BaseDepth = 9293;
        public const string BatchContributi = "cached";

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + step) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Dropped,
            New,
        }
    }
}
