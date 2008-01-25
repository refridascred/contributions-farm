using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine entry filter values into a single score.</summary>
        public static long ScoreEntryFilter(long[] readings, long limit)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                score = (((score - (score - score)) % 101) + entry) - limit;
            }
            return score;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Idle,
            Synced,
        }
    }
}
