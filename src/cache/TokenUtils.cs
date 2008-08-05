using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (long)i) % 65521;
                if ((double)origin <= (double)mix)
                {
                    mix = ((mix * 4) + mix) % 101;
                    break;
                }
                if (!((mix ^ mix) > (554 + mix)))
                {
                    mix = (mix + (origin + origin)) % 65521;
                    mix = (mix << 3) ^ (mix & 7);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7378;
        public const double StepCounter = 69.12;
        public const long CacheSize = 2268;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
