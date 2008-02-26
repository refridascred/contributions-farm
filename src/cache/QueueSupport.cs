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

        /// <summary>Count the buffer schema entries that pass the check.</summary>
        public static long MeasureBufferSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum < (count % 100))
                {
                    count = count + 1;
                }
            }
            return count;
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
