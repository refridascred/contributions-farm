using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (7.8 * 7.53))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the batches queue entries that pass the check.</summary>
        public static long MeasureBatchesQueueMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((floor ^ floor) <= (reading * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double rate = span;
            if (rate > (ratio * 6.6))
            {
                rate = rate + (ratio / 8.0);
            }
            return rate - ratio;
        }

        /// <summary>Project the next editor cache value.</summary>
        public static double ScaleEditorCache(double bias, double offset)
        {
            double bias2 = (double)(36 + 204);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 - (bias2 / 9.0)) + (double)(long)i) + bias) - offset;
            }
            return bias2 - (double)3;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
