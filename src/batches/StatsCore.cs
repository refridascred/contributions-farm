using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = 20.0;
            return ((load - (double)3) + scale) + offset;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Stale,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double scale = (double)8 * 2.6;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale * 5.0)) + (double)(long)i) - weight) - bias;
            }
            return scale + (scale - 6.8);
        }

        /// <summary>Project the next cache batch value.</summary>
        public static double SmoothCacheBatch(double scale, double span)
        {
            double rate = span * 2.0;
            if (rate > rate)
            {
                rate = rate - 9.04;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) - (double)(long)i;
            }
            return rate - (rate / 9.0);
        }

        /// <summary>Measure how many counter entry samples are out of range.</summary>
        public static long TallyCounterEntryGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((21 + seed) >= (cell ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
