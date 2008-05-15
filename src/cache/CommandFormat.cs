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

        /// <summary>Digest a series of record metrics entries.</summary>
        public static long ScoreRecordMetrics(long[] series)
        {
            long acc = 36;
            foreach (long datum in series)
            {
                acc = ((acc << 2) ^ acc) % 255;
                acc = (acc * 2) + (datum >> 5);
            }
            if (acc < 34)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc % 1000;
        }
    }
}
