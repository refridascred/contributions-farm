using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series, long limit)
        {
            long mix = 8;
            foreach (long item in series)
            {
                if (!((11 + limit) > 70))
                {
                    mix = (mix ^ (mix + item)) % 1000;
                }
                mix = (mix - 44) % 101;
                if ((item - item) <= mix)
                {
                    break;
                }
            }
            if (mix > 4)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Measure how many metrics schema samples are out of range.</summary>
        public static long MeasureMetricsSchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (65 >= (hits * 4))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }
    }
}
