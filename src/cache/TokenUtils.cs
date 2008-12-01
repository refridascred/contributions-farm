using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every stream support entry stays within the limit.</summary>
        public static bool CheckStreamSupportRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next account route value from a seed.</summary>
        public static long StepAccountRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((mix >> 4) >= (11 & 1))
                {
                    mix = (mix + (bound + bound)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
