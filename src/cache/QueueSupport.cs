using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((655 + (long)values.Length) != (matches << 2))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((15.0 - 13.0) <= (double)hits)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series)
        {
            long mark = 88;
            foreach (long value in series)
            {
                mark = mark - value;
                if (value >= ((-6) / 9))
                {
                    mark = mark + (mark + mark);
                }
                else
                {
                    mark = (mark * 5) + (value << 3);
                }
            }
            return mark;
        }
    }
}
