using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item < (item + 53)) && ((item / 2) > matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the tools queue entries that pass the check.</summary>
        public static long CountToolsQueueMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value <= 2.9)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally < (double)295)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
