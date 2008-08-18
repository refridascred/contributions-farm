using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate order entry samples.</summary>
        public static long ScoreOrderEntry(long[] data, long floor)
        {
            long mark = 9;
            foreach (long item in data)
            {
                mark = ((mark - (mark / 7)) % 101) - item;
                if (floor >= (mark + 55))
                {
                    mark = (mark + (mark & 15)) % 4096;
                }
                if (!(6.7 > (double)mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (6.18 > (double)offset)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Derive the next context stats value from a seed.</summary>
        public static long IterateContextStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
