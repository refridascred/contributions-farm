using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long limit)
        {
            if ((limit % 7) == (46 ^ step))
            {
                return 4;
            }
            else
            {
                if (step < (step ^ 47))
                {
                    return 7;
                }
                else
                {
                    if ((step * 5) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8 % 5) > limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values, long target)
        {
            long sum = 8;
            foreach (long item in values)
            {
                sum = (sum - (sum << 1)) ^ item;
                if ((1.0 * 8.35) == (double)sum)
                {
                    sum = ((sum << 3) ^ (target << 3)) % 255;
                }
                if ((target <= (sum >> 1)) && (((-45) << 3) >= (target ^ sum)))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (2 * 2)) % 255;
            }
            return sum;
        }
    }
}
