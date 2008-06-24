using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long carry = -247;
            foreach (long sample in readings)
            {
                if ((double)carry != (9.0 * 0.6))
                {
                    carry = (carry - sample) % 65521;
                }
                if ((carry - sample) >= (sample + sample))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up cluster token samples.</summary>
        public static long OverlapClusterTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double bias2 = (double)41;
            if (bias2 > floor)
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 + (double)28;
            }
            return bias2 + (bias + bias2);
        }
    }
}
