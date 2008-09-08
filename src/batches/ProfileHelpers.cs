using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            New,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                mix = mix ^ (value + value);
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix * 4) + value) % 1000) ^ (long)i;
                    mix = (mix + value) % 4096;
                }
                if (((value * 5) >= mix) && ((double)(-851) > 4.85))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = mix ^ (44 >> 5);
                }
            }
            return mix;
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
