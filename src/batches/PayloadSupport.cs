using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
