using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two format contributi measurements.</summary>
        public static double ProjectFormatContributi(double rate, double bias)
        {
            double weight = (double)985 + bias;
            if (weight > weight)
            {
                weight = weight - (rate * 5.0);
            }
            else
            {
                weight = weight - (bias + 17.0);
            }
            return weight - bias;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double rate = (span * 2.0) + span;
            if (rate > 2.2)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - gain) - (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Compare every pair of batch token readings.</summary>
        public static long PairBatchTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(67 >= result))
                {
                    result = (result - (floor << 3)) % 101;
                }
                result = (result * 5) + ((long)i / 2);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
