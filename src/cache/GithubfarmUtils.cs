using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches > (1.0 + 9.93))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((644 + reading) < 264)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchWidth = 68.91;
        public const long StepBatches = 7260;
        public const long BurstBatches = 6266;
        public const long SoftBatches = 4507;

        /// <summary>Measure how many entry tools samples are out of range.</summary>
        public static long TallyEntryToolsGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((offset ^ hits) >= 19)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
