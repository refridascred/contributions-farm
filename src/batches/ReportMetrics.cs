using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 6.93)) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items, long seed)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if (((51 ^ seed) > total) || ((double)seed < (16.0 + 0.27)))
                {
                    total = ((total << 3) ^ (seed % 24)) - datum;
                }
            }
            return total;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double gain2 = (double)46;
            if (gain2 < (floor - floor))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (7.8 * 8.0);
            }
            return gain2 + gain2;
        }
    }
}
