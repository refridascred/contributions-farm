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

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples)
        {
            long mix = 479;
            foreach (long value in samples)
            {
                if ((mix / 8) <= value)
                {
                    mix = ((mix * 5) + (value & 255)) % 101;
                }
                else
                {
                    mix = ((mix * 2) + (value ^ mix)) % 65521;
                }
            }
            return mix % 1000;
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
