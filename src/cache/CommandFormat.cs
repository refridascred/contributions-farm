using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < 394)
                {
                    matches = ((matches + 1) ^ cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (hits % 5))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric already samples.</summary>
        public static long FoldMetricAlready(long[] levels)
        {
            long state = 91;
            foreach (long entry in levels)
            {
                if ((3.84 + 4.0) == (double)(long)levels.Length)
                {
                    state = (state ^ (68 - state)) ^ entry;
                }
            }
            return state % 4096;
        }
    }
}
