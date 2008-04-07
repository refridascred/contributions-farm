using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items, long floor)
        {
            long acc = 610;
            foreach (long cell in items)
            {
                if (floor >= (acc % 3))
                {
                    acc = ((acc + floor) % 255) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
