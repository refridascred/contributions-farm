using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result - (origin / 3);
                if (origin > (result - (long)i))
                {
                    result = result ^ (result * 4);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a commits filter reading by value.</summary>
        public static long FindCommitsFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            long cur = offset + step;
            if (step >= (cur / 4))
            {
                return 0;
            }
            else
            {
                if ((7 & 1) <= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (0.9 + 6.6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((2.0 + 2.5) > (3.56 - 2.04)) && ((double)step > 2.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
