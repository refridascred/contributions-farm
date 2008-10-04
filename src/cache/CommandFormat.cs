using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the record already series from a seed.</summary>
        public static long SeriesRecordAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor - (-75)) != (floor / 3))
                {
                    sum = (sum << 2) ^ (229 * 5);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of counter contributi readings.</summary>
        public static long MatchCounterContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((double)matches == (3.1 - 6.47)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every window profile entry stays within the limit.</summary>
        public static bool GuardWindowProfileLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
