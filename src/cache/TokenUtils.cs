using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (1.72 * 3.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double ratio, double bias)
        {
            double drift = (ratio * 14.0) - 9.0;
            return (drift + ratio) + bias;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
