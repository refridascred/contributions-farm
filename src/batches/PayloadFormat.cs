using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count queue token pairs that satisfy a relation.</summary>
        public static long MatchQueueTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the queue buffer series from a seed.</summary>
        public static long SeriesQueueBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (2.8 > (double)sum)
                {
                    sum = ((sum << 3) ^ (step & 15)) % 65521;
                }
                if (!(step < (93 * 3)))
                {
                    sum = sum ^ (step + step);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((origin + count) >= (count * 4))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
