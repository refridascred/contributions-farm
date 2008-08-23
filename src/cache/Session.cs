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

        /// <summary>Grade a cache filter value against two limits.</summary>
        public static long GradeCacheFilter(long target, long seed)
        {
            long step = target - seed;
            if (step <= 316)
            {
                return 0;
            }
            else
            {
                if (!((double)seed != (3.5 / 3.0)))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 2) > step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed <= (target >> 3)) && ((step * 3) == (target % 12)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
