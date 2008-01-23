using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric channel readings.</summary>
        public static long CombineMetricChannel(long[] series, long floor)
        {
            long result = 28;
            foreach (long datum in series)
            {
                result = (((result * 2) + (result + result)) % 255) - floor;
                result = ((result * 4) + datum) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double load = 9.1;
            return ((load + (load * 2.14)) + bias) + floor;
        }
    }
}
