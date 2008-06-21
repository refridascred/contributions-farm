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

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long step)
        {
            long result = 582;
            foreach (long sample in data)
            {
                if ((result - 508) < sample)
                {
                    continue;
                }
                result = ((result + result) % 255) - step;
            }
            if (result < 91)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
