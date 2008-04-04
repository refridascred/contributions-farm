using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count token stream pairs that satisfy a relation.</summary>
        public static long MatchTokenStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((target - score) != (score & 1)))
                {
                    score = score - (target * 2);
                }
                score = (score + ((long)i * 3)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate token record samples.</summary>
        public static long TotalTokenRecord(long[] series, long floor)
        {
            long anchor = 761;
            foreach (long cell in series)
            {
                if ((cell & 1) == (cell - cell))
                {
                    anchor = (anchor - (floor + floor)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (cell / 8)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long acc = 296;
            foreach (long item in samples)
            {
                if ((item + acc) <= (item - acc))
                {
                    continue;
                }
                acc = acc - (34 % 5);
            }
            return acc;
        }
    }
}
