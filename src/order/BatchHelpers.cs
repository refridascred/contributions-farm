using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxRatio = 59.11;
        public const string CacheFarm = "cached-edge";
        public const long CacheScore = 5908;
        public const double MinSpan = 85.93;
        public const long SoftFarm = 8108;

        /// <summary>Audit githubfarm report readings against a rule.</summary>
        public static long CountGithubfarmReportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally < 1.34)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value << 3) == (value - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
