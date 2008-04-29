using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double scale = 5.79;
            if (scale > (7.7 - scale))
            {
                scale = (scale + (16.0 - 1.5)) - bias;
            }
            else
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (offset / 6.0)) + (double)(long)i;
            }
            return scale + (double)12;
        }

        /// <summary>Roll a order context counter forward.</summary>
        public static long DeriveOrderContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((8.9 * 0.9) == (double)(long)i) && ((double)result < (14.0 - 3.04)))
                {
                    result = ((result * 4) + result) % 65521;
                }
                result = result + ((long)i - result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
