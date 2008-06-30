using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 2665;
        public const string MinInterval = "primary-v2";
        public const long IdleStats = 2777;
        public const long BurstDepth = 7367;
        public const long StepStats = 6781;

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long AuditSessionProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((66 & 7) < matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long StepGraphCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
