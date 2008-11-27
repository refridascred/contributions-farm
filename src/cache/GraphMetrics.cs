using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Draft,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.44 - 4.19) < (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster contributi readings.</summary>
        public static long TotalClusterContributi(long[] levels)
        {
            long score = 58;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score ^ (score + score)) % 4096) - (long)i;
                    score = score - (score + score);
                }
                score = score - sample;
            }
            return score;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 4492;
        public const long BatchChannel = 755;
        public const long RetrySize = 4385;
    }
}
