using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double gain = (0.8 * 5.0) - (double)6;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (floor - gain)) + (double)(long)i) + weight;
            }
            return gain - gain;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading < seen) || (seen <= (7 - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
