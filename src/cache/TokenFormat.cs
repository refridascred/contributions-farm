using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the order context series from a seed.</summary>
        public static long RollOrderContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a batches route value against two limits.</summary>
        public static long BucketBatchesRoute(long offset, long origin)
        {
            if (!(origin < (origin * 5)))
            {
                return 2;
            }
            else
            {
                if ((double)origin != (8.0 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (20.0 + 8.5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up layout filter samples.</summary>
        public static long CompareLayoutFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
