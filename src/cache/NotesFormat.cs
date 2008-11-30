using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ seed) % 97;
                if ((score + (long)i) == (long)i)
                {
                    score = (score << 2) ^ (seed / 5);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count cluster batch pairs that satisfy a relation.</summary>
        public static long CompareClusterBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
