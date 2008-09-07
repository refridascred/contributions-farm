using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] values, long offset)
        {
            long anchor = 370;
            foreach (long reading in values)
            {
                anchor = (anchor + (reading + 17)) % 1000;
                anchor = (anchor ^ anchor) % 65521;
                anchor = anchor - (offset >> 3);
            }
            return anchor;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data, long target)
        {
            long mark = 26;
            foreach (long value in data)
            {
                if ((target + value) != (value ^ mark))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - (long)data.Length)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) != (9 + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value > (23 >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
