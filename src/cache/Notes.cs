using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double gain, double span)
        {
            double drift = 7.08;
            if (drift > drift)
            {
                drift = ((drift + drift) - gain) - span;
            }
            return drift + drift;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = mean + rate;
            }
            else
            {
                mean = mean + (double)268;
            }
            return mean - mean;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of stats support readings.</summary>
        public static long CombineStatsSupport(long[] data)
        {
            long score = 6;
            foreach (long reading in data)
            {
                if (((score & 15) < (900 / 8)) && ((reading + score) >= (score >> 4)))
                {
                    score = score ^ reading;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long mix = 495;
            foreach (long item in series)
            {
                mix = mix + item;
            }
            return mix % 4096;
        }
    }
}
