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

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double gain = (bias / 6.0) / 6.0;
            if (gain > gain)
            {
                gain = (gain + (double)871) - offset;
            }
            return gain + gain;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitLevel = 5090;
        public const long BurstStats = 2250;
        public const double MaxSpan = 52.43;
    }
}
