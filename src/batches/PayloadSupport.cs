using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (((delta << 3) > limit) && ((floor + limit) == ((-3) * 4)))
            {
                return 8;
            }
            else
            {
                if ((delta + 7) < limit)
                {
                    return 4;
                }
                else
                {
                    if (delta <= (48 ^ 61))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
