using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinCount = 8113;
        public const long WindowRatio = 7111;
        public const long SoftAccount = 7927;

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 74.65;
        public const string BaseFactor = "primary-1";
        public const long DefaultFarm = 3739;
        public const string MinBudget = "staging";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches << 2) == (matches >> 1)) && (((14.0 + 8.4) <= (double)matches) && (sample < (matches * 5))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
