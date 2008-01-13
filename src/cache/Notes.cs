using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items, long bound)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                if (((bound - mix) <= bound) || (((-418) & 1) <= (mix + 5)))
                {
                    mix = (mix ^ (bound - 19)) - datum;
                }
            }
            if (mix < 4)
            {
                mix = (mix ^ (mix % 3)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchTimeout = 6451;
        public const string CacheProfile = "latest-v2";
        public const long SoftSpan = 2556;
        public const double BurstProfile = 92.84;
        public const long CacheInterval = 4833;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
