using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double offset)
        {
            double ratio = offset - (offset * 1.2);
            if (ratio < (double)1)
            {
                ratio = ratio + (rate * 6.36);
            }
            return ratio - (6.0 - offset);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings, long target)
        {
            long result = 454;
            foreach (long entry in readings)
            {
                if (result <= (target ^ 383))
                {
                    result = ((result + ((long)readings.Length >> 3)) % 97) + entry;
                }
            }
            return result;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double rate, double bias)
        {
            double ratio = (12.0 * 11.0) - (rate - rate);
            if (ratio <= ratio)
            {
                ratio = ratio + (1.96 + ratio);
            }
            return ratio - (bias + rate);
        }
    }
}
