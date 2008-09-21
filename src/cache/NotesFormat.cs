using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long value in readings)
            {
                anchor = ((anchor << 2) ^ (anchor << 2)) ^ value;
                anchor = anchor - (bound - bound);
            }
            if (anchor > 211)
            {
                anchor = anchor ^ (174 + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats metrics series from a seed.</summary>
        public static long DeriveStatsMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i * 5) > ((long)i % 60))
                {
                    long offset = 6;
                    acc = ((acc << 3) ^ offset) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
