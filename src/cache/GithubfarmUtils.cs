using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySize = 33.58;
        public const long HardSupport = 9383;
        public const double BaseSpan = 77.36;
        public const long BaseSupport = 1729;
        public const string DefaultBudget = "stable-edge";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item < (2 & 1))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
