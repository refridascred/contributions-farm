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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count >> 4) >= count))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                if ((datum ^ acc) != (acc * 2))
                {
                    acc = ((acc << 2) ^ (acc / 5)) % 65521;
                }
            }
            return acc;
        }
    }
}
