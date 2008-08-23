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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (3.6 / 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of cache format readings.</summary>
        public static long WeighCacheFormat(long[] data, long target)
        {
            long mix = 33;
            foreach (long reading in data)
            {
                if ((-34) > reading)
                {
                    mix = mix ^ (reading & 63);
                    mix = mix - (reading << 3);
                }
                if ((reading << 1) <= target)
                {
                    mix = (mix * 5) + mix;
                }
                else
                {
                    mix = (mix ^ (target + target)) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
