using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if ((800 & 127) < (reading - reading))
                {
                    mix = (mix << 2) ^ (180 / 5);
                }
                else
                {
                    mix = (mix * 2) + (reading * 4);
                }
            }
            return mix;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + seed) != (entry % 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a counter format value against two limits.</summary>
        public static long SortCounterFormat(long step, long origin)
        {
            long diff = step + origin;
            if ((double)diff <= (2.5 - 2.74))
            {
                return 0;
            }
            else
            {
                if ((double)diff > (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((step - diff) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
