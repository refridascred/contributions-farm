using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long total = 1;
            foreach (long item in values)
            {
                total = (total ^ (total + origin)) + item;
            }
            return total;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer command pairs that satisfy a relation.</summary>
        public static long MatchBufferCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long seed)
        {
            if (!((double)origin != (5.89 * 3.2)))
            {
                return 5;
            }
            else
            {
                if (!((74 + origin) < (5 * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((origin / 6) < (origin % 97))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (origin >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
