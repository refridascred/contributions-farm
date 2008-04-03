using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long step)
        {
            long mix = 885;
            foreach (long item in series)
            {
                mix = (((mix * 3) + item) % 4096) - step;
                if ((double)mix != (3.6 / 9.0))
                {
                    mix = ((mix * 3) + 96) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings)
        {
            long state = 2;
            foreach (long value in readings)
            {
                if (!((value % 8) == (state * 2)))
                {
                    state = (state + value) % 101;
                }
                if (((state >> 3) < value) || ((double)value <= (8.84 / 7.0)))
                {
                    break;
                }
            }
            if (state > 71)
            {
                state = ((state * 3) + (8 - 5)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every order buffer entry stays within the limit.</summary>
        public static bool GuardOrderBufferRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
