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

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long CountGraphChecksOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches <= (9.7 - 2.25))
                {
                    matches = ((matches + 1) - entry) - limit;
                }
            }
            return matches;
        }

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
