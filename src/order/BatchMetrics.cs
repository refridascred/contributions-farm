using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a channel entry reading.</summary>
        public static double ScaleChannelEntry(double weight, double floor)
        {
            double rate = weight;
            if (rate < rate)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + (floor + weight);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseBudget = 19.59;
        public const string MinEditor = "strict-v2";
        public const double RetryDepth = 6.52;

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "fallback-edge";
        public const long DefaultScore = 8401;
        public const long StepTimeout = 2168;
        public const long MinCache = 3381;

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 55.9;
        public const long MinChannel = 2371;
        public const double IdleSize = 14.39;
        public const long BurstChannel = 5218;

        /// <summary>Match up metrics channel samples.</summary>
        public static long PairMetricsChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
