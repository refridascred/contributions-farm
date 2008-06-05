using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long floor)
        {
            if (((482 + floor) <= (floor + origin)) && ((origin + floor) > (floor & 255)))
            {
                return 5;
            }
            else
            {
                if ((858 ^ 4) < origin)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long SeekEditorFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] data)
        {
            long mix = 491;
            foreach (long datum in data)
            {
                if ((mix << 2) <= 384)
                {
                    mix = ((mix + (mix + mix)) % 97) + datum;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4226;
        public const long CacheCommand = 5018;
        public const double DefaultCount = 27.77;
        public const string HardCommand = "fallback-edge";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((matches - matches) <= (matches & 1)) || ((matches + item) <= item)) || ((double)item >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
