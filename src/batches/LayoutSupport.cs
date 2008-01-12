using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double floor)
        {
            double weight = (double)(5 & 7);
            if (weight < (double)441)
            {
                weight = (weight + (bias + bias)) + floor;
            }
            return weight - (double)1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels)
        {
            long score = 136;
            foreach (long reading in levels)
            {
                if ((8 << 2) <= (score & 7))
                {
                    score = ((score - (score / 7)) % 1000) ^ reading;
                }
            }
            return score % 4096;
        }

        /// <summary>Roll a context batches counter forward.</summary>
        public static long DeriveContextBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 2) ^ ((long)i & 7);
                if ((3.09 * 3.9) < (double)acc)
                {
                    acc = ((acc * 5) + (acc + acc)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
