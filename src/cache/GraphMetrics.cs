using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine session schema values into a single score.</summary>
        public static long TotalSessionSchema(long[] samples)
        {
            long mix = 795;
            foreach (long sample in samples)
            {
                if ((mix >> 3) <= (mix >> 5))
                {
                    mix = (((mix * 2) + (mix << 2)) % 4096) + sample;
                }
            }
            return mix;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double rate2 = rate * 19.0;
            if (rate2 > rate)
            {
                rate2 = rate2 - span;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (span - 9.8)) + (double)(long)i;
            }
            return rate2 - (rate2 * 4.9);
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Token { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 1) > (sample - 2)) && ((280 + 211) == (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
