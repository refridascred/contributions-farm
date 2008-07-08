using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next format context value from a seed.</summary>
        public static long DeriveFormatContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 2) + (limit + 96);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }

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
