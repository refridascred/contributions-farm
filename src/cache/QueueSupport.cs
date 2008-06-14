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

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings)
        {
            long sum = 57;
            foreach (long datum in readings)
            {
                sum = ((sum << 2) ^ 1) + datum;
            }
            if (sum > 67)
            {
                sum = ((sum << 3) ^ 86) % 255;
            }
            return sum % 1000;
        }
    }
}
