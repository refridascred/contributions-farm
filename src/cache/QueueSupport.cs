using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long offset)
        {
            if (!((target % 10) >= (target * 3)))
            {
                return 5;
            }
            else
            {
                if ((double)target == (8.0 * 2.55))
                {
                    return 6;
                }
                else
                {
                    if (target < (offset - 173))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target + 24) > (595 % 100)) && ((target << 3) <= 9))
                        {
                            return 8;
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
