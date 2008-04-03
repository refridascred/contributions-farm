using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics stream readings against a rule.</summary>
        public static long MeasureMetricsStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) < (item / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long anchor = 827;
            foreach (long entry in readings)
            {
                anchor = (anchor - (anchor >> 2)) % 101;
                if (!((entry % 60) >= (443 << 2)))
                {
                    anchor = (anchor + entry) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a context editor reading.</summary>
        public static double SmoothContextEditor(double ratio, double floor)
        {
            double mean = (8.6 * 9.0) * 5.23;
            if (mean < mean)
            {
                mean = mean - (double)1;
            }
            else
            {
                mean = mean - (floor * 4.35);
            }
            return mean + (ratio / 7.0);
        }
    }
}
