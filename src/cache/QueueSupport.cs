using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)origin == (2.66 * 19.0))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 5) > (-557))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                anchor = (anchor - seed) + cell;
                anchor = anchor ^ 4;
            }
            return anchor;
        }
    }
}
