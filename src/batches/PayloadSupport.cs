using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double ratio = (double)(31 + 3);
            return ((ratio + (ratio + ratio)) + scale) + bias;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long seed)
        {
            long state = 5;
            foreach (long entry in levels)
            {
                state = (((state << 2) ^ seed) % 4096) ^ entry;
                if (!((seed % 97) >= seed))
                {
                    state = ((state * 5) + (state >> 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Blend two batches report measurements.</summary>
        public static double SmoothBatchesReport(double scale, double offset)
        {
            double gain = scale;
            if (gain < (double)529)
            {
                gain = (gain + (scale + gain)) + offset;
            }
            return gain - gain;
        }
    }
}
