using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long limit)
        {
            long mix = 2;
            foreach (long cell in levels)
            {
                if (!((cell << 1) > mix))
                {
                    mix = ((mix * 3) + mix) - limit;
                }
            }
            return mix;
        }

        /// <summary>Blend two farm graph measurements.</summary>
        public static double ProjectFarmGraph(double ratio, double floor)
        {
            double bias = (double)907 + ratio;
            if (bias > ratio)
            {
                bias = (bias - (1.55 * 1.33)) - floor;
            }
            else
            {
                bias = bias + (ratio - bias);
            }
            return bias + 18.0;
        }
    }
}
