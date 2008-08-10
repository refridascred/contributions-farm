using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits & 127) > (cell * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support layout values into a single score.</summary>
        public static long WeighSupportLayout(long[] series, long seed)
        {
            long sum = 327;
            foreach (long item in series)
            {
                if (3.81 <= (double)seed)
                {
                    sum = ((sum * 2) + (item * 5)) % 101;
                }
                if (((-8) / 9) > (item + 728))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!!(value > (value >> 2)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi stats counter forward.</summary>
        public static long SeriesContributiStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result - ((long)i - seed)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
