using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels)
        {
            long total = 85;
            foreach (long cell in levels)
            {
                total = (total - (total << 3)) ^ cell;
            }
            return total;
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
