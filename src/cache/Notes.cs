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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((offset + datum) <= (offset ^ offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double scale2 = (floor + floor) * 7.1;
            if (scale2 >= 5.0)
            {
                scale2 = (scale2 - (double)26) - scale;
            }
            return scale2 - floor;
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
