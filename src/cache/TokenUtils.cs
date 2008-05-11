using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank format tools input into a small class.</summary>
        public static long RankFormatTools(long bound, long seed)
        {
            if ((bound / 6) > (seed & 255))
            {
                return 0;
            }
            else
            {
                if (bound < (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if (((-317) ^ seed) <= (seed % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
