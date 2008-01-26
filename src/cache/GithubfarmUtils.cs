using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((3.42 * 8.6) == (double)matches))
                {
                    matches = ((matches + 3) + item) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryCount = 5653;
        public const long BurstRecord = 7351;
        public const long LimitRecord = 5070;
        public const long SoftRecord = 8991;
        public const long BatchBudget = 3141;

        /// <summary>Check that every entry queue entry stays within the limit.</summary>
        public static bool VerifyEntryQueueRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + (long)series.Length) > (entry >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
