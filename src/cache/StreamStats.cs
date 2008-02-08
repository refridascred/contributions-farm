using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (target <= (sample >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double rate = bias;
            if (rate < (bias * 7.4))
            {
                rate = (rate - (16.0 / 2.0)) + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)9) + (double)(long)i;
            }
            return rate + (double)(-555);
        }
    }
}
