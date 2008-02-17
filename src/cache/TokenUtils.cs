using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double bias = span;
            if (bias < span)
            {
                bias = bias + (bias + rate);
            }
            else
            {
                bias = bias - (span * 5.5);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (bias / 5.0);
        }
    }
}
