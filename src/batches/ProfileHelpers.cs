using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double scale = 6.0 - (1.09 * 8.2);
            if (scale <= (bias / 9.0))
            {
                scale = (scale - 3.48) - offset;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + 7.14;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >> 5) != (844 << 1))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + seed) % 65521;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 83.14;
        public const long HardFactor = 5141;
        public const double BurstCount = 84.53;
        public const long BaseLayout = 8056;

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double bias)
        {
            double drift = bias;
            if (drift < (2.12 * 8.0))
            {
                drift = (drift - (double)10) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)390;
        }

        /// <summary>Count the notes queue entries that pass the check.</summary>
        public static long TallyNotesQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches + entry) > 7) && ((entry * 2) > 8))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
