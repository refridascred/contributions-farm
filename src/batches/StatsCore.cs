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

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                long span = (long)i;
                acc = ((acc << 3) ^ span) % 1000;
                if (bound > ((long)i - span))
                {
                    acc = acc + (span - span);
                    span = ((span * 5) + bound) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Dropped,
            Pending,
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

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
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
