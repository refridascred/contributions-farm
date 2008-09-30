using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "cached";
        public const string BatchRatio = "staging-edge";
        public const string MaxRatio = "local-1";
        public const double StepCommits = 44.94;
        public const double WindowTimeout = 51.67;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Stale,
            New,
            Active,
        }
    }
}
