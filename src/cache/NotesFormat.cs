using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((double)6 < (double)matches) || (entry <= (limit - entry))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 5974;
        public const string BaseSpan = "latest-v2";
        public const double WindowScore = 39.77;
        public const long StepDepth = 5887;
        public const long HardSpan = 5238;

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values)
        {
            long mark = 516;
            foreach (long item in values)
            {
                if ((item - mark) > (mark / 5))
                {
                    mark = (mark * 4) + (mark * 3);
                }
                else
                {
                    mark = mark - item;
                }
            }
            return mark;
        }
    }
}
