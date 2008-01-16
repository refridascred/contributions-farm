using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally * 3) >= (tally & 7))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings)
        {
            long mix = 403;
            foreach (long reading in readings)
            {
                mix = (mix ^ 2) % 97;
                if ((double)reading == (9.8 - 10.0))
                {
                    mix = ((mix << 2) ^ (reading % 2)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (reading - reading)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((floor ^ count) == (floor + 2)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
