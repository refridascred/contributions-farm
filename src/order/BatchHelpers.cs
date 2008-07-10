using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (3.47 - 3.2))
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long offset)
        {
            long mark = -4;
            foreach (long cell in levels)
            {
                if ((mark << 3) >= cell)
                {
                    mark = ((mark << 2) ^ (mark + mark)) + offset;
                }
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((seen & 7) > 5) && (sample >= (sample / 9)))
                {
                    seen = (seen + 1) + seed;
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
