using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen / 9) < sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long mark = 73;
            foreach (long item in series)
            {
                if (((mark / 8) == (mark % 10)) && ((item * 3) <= mark))
                {
                    mark = ((mark - ((long)series.Length + item)) % 101) - origin;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Total { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long offset)
        {
            if ((11.0 / 3.0) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (offset < (offset >> 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
