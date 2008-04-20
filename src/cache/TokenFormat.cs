using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long seed)
        {
            long mix = 92;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (((mix - (cell >> 4)) % 101) ^ (long)i) - seed;
                    mix = mix - (cell % 5);
                }
                mix = (mix - ((-6) & 1)) % 255;
            }
            return mix;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + 57) >= (cell >> 2))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
