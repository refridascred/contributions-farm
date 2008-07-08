using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Synced,
            New,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long step)
        {
            long score = -95;
            foreach (long reading in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score + (step * 3)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - reading) % 4096) + (long)i2;
                }
                score = (score + (score / 6)) % 101;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 5979;
        public const long BaseFactor = 8056;
        public const long MinTimeout = 1749;
        public const double WindowPayload = 1.83;
        public const long BatchPayload = 6423;

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultSpan = "standard";
        public const long BurstWidth = 1252;
        public const long RetryTimeout = 1623;
        public const string CacheBudget = "cached-1";
        public const long SoftEditor = 8204;

        /// <summary>Scale a batches metric figure with a bias.</summary>
        public static double ProjectBatchesMetric(double rate, double offset)
        {
            double ratio = offset + (rate + rate);
            if (ratio >= offset)
            {
                ratio = ratio + (rate / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (offset - offset);
        }
    }
}
