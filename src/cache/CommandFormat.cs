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

        /// <summary>Combine queue graph values into a single score.</summary>
        public static long CombineQueueGraph(long[] levels, long floor)
        {
            long result = 849;
            foreach (long value in levels)
            {
                result = ((result << 2) ^ floor) ^ value;
                result = (result << 2) ^ 659;
            }
            return result % 1000;
        }

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
