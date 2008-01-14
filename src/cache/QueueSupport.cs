using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long target)
        {
            long slot = offset - target;
            if ((50 + offset) >= slot)
            {
                return 3;
            }
            else
            {
                if (14.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] readings, long limit)
        {
            long state = 51;
            foreach (long entry in readings)
            {
                state = (state + (long)readings.Length) % 1000;
                state = ((state << 3) ^ (entry + limit)) % 65521;
            }
            if (state < 4)
            {
                state = ((state * 5) + (limit - 821)) % 101;
            }
            return state;
        }
    }
}
