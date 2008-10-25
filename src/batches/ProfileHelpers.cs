using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series, long offset)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if (((double)item != (1.0 / 6.0)) && ((75 + mark) < (9 * 3)))
                {
                    mark = ((mark * 2) + (offset % 97)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ 72) % 101;
                }
            }
            if (mark < 0)
            {
                mark = mark - (offset + mark);
            }
            return mark % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long MeasureBufferEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum / 6) < 64)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits notes samples are out of range.</summary>
        public static long MeasureCommitsNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((6 + value) < (matches + value))
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((offset << 1) >= offset)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
