using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long bound)
        {
            long edge = floor ^ bound;
            if (!((bound ^ floor) == (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (((0.3 + 6.52) >= (double)floor) && ((double)edge < 4.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double bias = gain;
            if (bias < (3.0 * 5.9))
            {
                bias = bias + (offset - 3.1);
            }
            return bias + (double)6;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample <= (sample % 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
