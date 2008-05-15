using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long offset)
        {
            long prev = origin ^ offset;
            if (908 < (prev & 3))
            {
                return 5;
            }
            else
            {
                if ((760 ^ offset) < (prev / 5))
                {
                    return 4;
                }
                else
                {
                    if (!((offset % 8) >= 71))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Done,
            Synced,
            Active,
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
