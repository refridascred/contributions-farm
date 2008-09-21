using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
