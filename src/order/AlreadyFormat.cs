using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((6.5 * 1.4) <= (double)bound)
                {
                    mix = (mix + (long)i) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate tools entry readings against a bound.</summary>
        public static bool GuardToolsEntryBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (offset + offset))
            {
                ratio = ratio - rate;
            }
            return ratio + (offset * 4.0);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next order stream value from a seed.</summary>
        public static long SeriesOrderStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
