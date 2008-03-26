using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample >= 3.3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long TallyChannelLayoutMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((floor ^ (long)items.Length) < cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch contributi value from a seed.</summary>
        public static long RollBatchContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - (mark - origin)) % 255;
                if (mark < (74 % 2))
                {
                    mark = (mark - 375) % 101;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Synced,
            Active,
        }
    }
}
