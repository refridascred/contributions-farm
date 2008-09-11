using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long seed)
        {
            long score = 62;
            foreach (long cell in readings)
            {
                score = ((((score << 2) ^ (4 ^ (long)readings.Length)) % 65521) + cell) + seed;
            }
            return score;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Retry,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)target >= (double)hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
