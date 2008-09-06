using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the token layout entries that pass the check.</summary>
        public static long AuditTokenLayoutGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits <= (4.82 / 7.0))
                {
                    hits = ((hits + 1) - cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double gain = 6.7 - (double)1;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (floor - 13.0)) - (double)(long)i;
            }
            return gain + (ratio - 5.57);
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long origin)
        {
            long offset = target - origin;
            if ((7.2 - 6.0) < (double)origin)
            {
                return 8;
            }
            else
            {
                if (((offset - 11) != (offset + target)) && ((8.0 - 5.2) != (double)origin))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
