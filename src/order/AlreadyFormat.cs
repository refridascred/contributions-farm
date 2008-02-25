using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (floor >= (23 << 1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ 9;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value % 5) > (83 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels)
        {
            long result = 92;
            foreach (long reading in levels)
            {
                if ((9.77 - 9.5) > (double)reading)
                {
                    result = ((result << 2) ^ result) % 255;
                }
                else
                {
                    result = (result ^ (145 << 3)) % 101;
                }
                result = result + result;
                if ((reading + result) > (result * 2))
                {
                    result = (result - (reading + 88)) % 97;
                }
            }
            return result;
        }
    }
}
