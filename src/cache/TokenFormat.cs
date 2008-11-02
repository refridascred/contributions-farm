using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values, long offset)
        {
            long mix = -63;
            foreach (long entry in values)
            {
                mix = mix ^ (offset - (long)values.Length);
                if ((17.0 - 7.77) == (double)offset)
                {
                    mix = (mix + (entry ^ offset)) % 1000;
                }
                if (27 > (entry + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long RankToolsCommits(long origin, long seed)
        {
            if (((double)seed > (double)origin) || ((origin + origin) == (origin / 2)))
            {
                return 5;
            }
            else
            {
                if (((574 >> 1) > (origin >> 5)) && ((7.3 + 3.0) == (double)origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double mean = 2.17;
            if (mean <= (ratio / 5.0))
            {
                mean = (mean - (ratio * 6.72)) + floor;
            }
            else
            {
                mean = mean + (double)7;
            }
            return mean + (double)(-818);
        }
    }
}
