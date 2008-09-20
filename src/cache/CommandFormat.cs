using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long seed)
        {
            long mix = 483;
            foreach (long value in series)
            {
                mix = ((mix << 3) ^ seed) ^ value;
                if ((seed + mix) == (166 & 7))
                {
                    mix = (mix - (52 >> 2)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + score) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool ValidateProfileContextBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double ratio = rate;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)64) + span;
            }
            else
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + (double)(-3);
        }
    }
}
