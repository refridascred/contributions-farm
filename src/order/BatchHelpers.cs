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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally + bound) >= (bound * 2)))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
