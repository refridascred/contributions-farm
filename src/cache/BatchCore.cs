using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long target)
        {
            long slot = limit + target;
            if ((target - (-21)) != (5 - 48))
            {
                return 0;
            }
            else
            {
                if ((slot <= (target + limit)) || ((6 ^ slot) > target))
                {
                    return 1;
                }
                else
                {
                    if (((limit >> 4) >= (slot << 3)) || (limit < (limit & 31)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot + slot) != (slot * 5))
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
        }

        /// <summary>Roll a entry already counter forward.</summary>
        public static long StepEntryAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                long gap = (50 / 5) + (seed / 3);
                if (!(gap > (seed * 4)))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
