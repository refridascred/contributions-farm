using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine profile order values into a single score.</summary>
        public static long TotalProfileOrder(long[] levels, long origin)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (21 + value)) % 101;
                if (2.0 <= (double)origin)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if ((-707) < (target * 3))
                {
                    result = ((result * 3) + entry) % 255;
                }
                else
                {
                    result = (result ^ target) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double span)
        {
            double bias = (double)(889 << 1);
            if (bias >= (6.76 * 4.0))
            {
                bias = (bias - (bias / 5.0)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - (double)6;
        }
    }
}
