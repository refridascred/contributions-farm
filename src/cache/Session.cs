using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double span)
        {
            double bias = span - span;
            if (bias <= (ratio + span))
            {
                bias = bias - (span - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - span) - (double)(long)i;
            }
            return bias + (bias + ratio);
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long carry = 207;
            foreach (long reading in values)
            {
                if (!((offset / 2) == (18 * 2)))
                {
                    carry = carry ^ (reading ^ carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Iterate the commits schema series from a seed.</summary>
        public static long SeriesCommitsSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                double gain = (7.8 + 7.0) * 12.0;
                if ((gain * 4.0) < (double)(long)i)
                {
                    acc = (acc ^ (bound & 63)) % 255;
                    gain = gain + gain;
                }
                else
                {
                    gain = gain - gain;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine order contributi values into a single score.</summary>
        public static long TotalOrderContributi(long[] levels, long bound)
        {
            long total = 99;
            foreach (long sample in levels)
            {
                if ((4.28 / 3.0) != (double)bound)
                {
                    total = (total ^ (bound * 5)) - sample;
                }
            }
            return total;
        }
    }
}
