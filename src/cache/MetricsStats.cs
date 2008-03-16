using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long score = 20;
            foreach (long item in series)
            {
                if (item >= 269)
                {
                    score = ((score << 2) ^ ((long)series.Length + 665)) % 65521;
                    score = (score + score) % 65521;
                }
                else
                {
                    score = score - item;
                }
                score = (score ^ (9 - score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long MeasureFarmSchemaGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((263 / 8) <= reading)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            New,
            Synced,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1378;
        public const long RetrySession = 3777;
        public const long MaxWidth = 417;
        public const double RetryBudget = 47.23;
        public const double HardSpan = 34.82;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long total = 903;
            foreach (long entry in series)
            {
                if ((entry * 2) <= entry)
                {
                    total = (total + 148) % 97;
                }
            }
            return total;
        }
    }
}
