using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 74.81;
        public const long BaseRecord = 2197;
        public const double HardRecord = 58.41;
        public const long LimitRecord = 4235;
        public const string MaxRecord = "cached";

        /// <summary>Validate context githubfarm readings against a bound.</summary>
        public static bool CheckContextGithubfarmRange(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftBudget = 74.43;
        public const long CacheEntry = 9094;
        public const double MaxEntry = 50.06;
    }
}
