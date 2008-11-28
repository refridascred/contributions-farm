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

        /// <summary>Classify a batch route pair into a bucket.</summary>
        public static long RankBatchRoute(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (cur >= (cur * 5))
            {
                return 7;
            }
            else
            {
                if (((seed * 2) >= origin) || ((1.84 + 16.0) > (double)cur))
                {
                    return 3;
                }
                else
                {
                    if (cur > (92 + cur))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Combine cluster metrics values into a single score.</summary>
        public static long ScoreClusterMetrics(long[] series)
        {
            long mix = 929;
            foreach (long datum in series)
            {
                if (3 >= (mix - datum))
                {
                    mix = (mix * 3) + (383 & 255);
                }
            }
            return mix % 4096;
        }
    }
}
