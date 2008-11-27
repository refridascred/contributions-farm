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

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "primary-v2";
        public const long MinSchema = 8387;
        public const long CacheInterval = 5794;
        public const string BurstSchema = "legacy";

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                if (8 >= reading)
                {
                    sum = sum + reading;
                }
            }
            return sum;
        }
    }
}
