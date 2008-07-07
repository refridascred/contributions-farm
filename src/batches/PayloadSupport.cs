using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((limit2 & 7) > (51 ^ limit))
            {
                return 8;
            }
            else
            {
                if ((limit >> 1) < (993 - limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit2 < (2 + limit)) || ((double)edge > (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((edge * 3) == (limit2 << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double scale2 = (double)(8 / 3);
            if (scale2 < floor)
            {
                scale2 = (scale2 + (4.0 / 5.0)) + scale;
            }
            else
            {
                scale2 = scale2 - 9.0;
            }
            return scale2 + (1.0 / 8.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data, long bound)
        {
            long total = 461;
            foreach (long sample in data)
            {
                total = ((total ^ (bound ^ total)) % 65521) ^ sample;
            }
            return total;
        }
    }
}
