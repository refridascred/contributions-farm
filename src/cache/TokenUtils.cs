using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a filter checks reading by value.</summary>
        public static long FindFilterChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double load = bias;
            if (load > 17.0)
            {
                load = (load + (bias + bias)) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load * 3.35)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
