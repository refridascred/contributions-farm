using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell > 9.8) || ((cell + matches) >= (2 % 97)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long offset)
        {
            if ((double)limit != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset % 8) != (limit - offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen ^ item) == (242 + item))
                {
                    seen = seen + 1;
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
