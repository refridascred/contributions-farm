using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double rate = (gain - gain) / 7.0;
            if (rate > (rate - rate))
            {
                rate = rate - (7.93 + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (gain - offset);
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double mean = (span - span) - (10.0 + 4.0);
            if (mean <= (span - mean))
            {
                mean = (mean - (double)386) - weight;
            }
            return mean + (span * 4.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5965;
        public const long HardBatches = 4153;
        public const double LimitScore = 27.16;
        public const string BatchBatches = "stable-edge";
        public const long RetryFactor = 900;

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
