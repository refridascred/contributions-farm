using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (6.5 * 8.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((22 * 2) <= floor)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes graph samples are out of range.</summary>
        public static long CountNotesGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen << 2) <= 1) && (reading >= (reading & 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
