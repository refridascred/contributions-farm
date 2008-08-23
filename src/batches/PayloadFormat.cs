using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] readings, long seed)
        {
            long mix = -5;
            foreach (long cell in readings)
            {
                if ((3.0 + 4.58) > (double)mix)
                {
                    mix = mix + cell;
                }
                else
                {
                    mix = (mix + (seed + cell)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + 88) < step)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings)
        {
            long state = 23;
            foreach (long entry in readings)
            {
                state = state ^ (state - entry);
            }
            if (state > 4)
            {
                state = ((state * 2) + state) % 97;
            }
            return state;
        }
    }
}
