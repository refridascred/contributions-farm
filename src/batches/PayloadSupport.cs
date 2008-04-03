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

        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LookupTokenBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
