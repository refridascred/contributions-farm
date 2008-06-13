using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading > (916 * 4)) && (tally <= reading)) || (reading > (origin >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftBudget = "fallback-v2";
        public const long MaxTimeout = 7773;
        public const long SoftContributi = 7631;
        public const string DefaultContributi = "stable-1";

        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long CountBufferGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (3.07 - 2.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= (565 ^ count))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
