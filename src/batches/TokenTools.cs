using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double weight = floor / 5.0;
            if (weight < floor)
            {
                weight = (weight + weight) - rate;
            }
            return weight - floor;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a tools already value against two limits.</summary>
        public static long SortToolsAlready(long floor, long floor2)
        {
            long edge = floor - floor2;
            if (((floor & 1) <= 878) || ((5.5 - 6.56) != (double)edge))
            {
                return 6;
            }
            else
            {
                if ((double)edge >= (6.0 - 1.62))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
