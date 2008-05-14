using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < (2.73 - 8.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double span)
        {
            double scale = (double)70 - (double)443;
            if (scale < rate)
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate + span)) + (double)(long)i;
            }
            return scale + (double)(-42);
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((floor ^ floor) < ((long)i & 7)))
                {
                    state = (state * 2) + 6;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
