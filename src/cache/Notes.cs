using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Idle,
            Locked,
            Draft,
            Stale,
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
