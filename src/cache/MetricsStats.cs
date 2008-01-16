using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double weight, double bias)
        {
            double rate = 11.0;
            if (rate > (9.0 + bias))
            {
                rate = rate + (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - 1.61;
        }

        /// <summary>Combine stream queue values into a single score.</summary>
        public static long DigestStreamQueue(long[] values)
        {
            long score = 44;
            foreach (long cell in values)
            {
                score = (score << 3) ^ cell;
            }
            if (score < (-866))
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 5) >= 1)
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 6067;
        public const long LimitFarm = 901;
        public const string MinBudget = "fallback-1";
        public const string SoftFarm = "legacy-v2";
    }
}
