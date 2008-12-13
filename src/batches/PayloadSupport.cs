using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of order record readings.</summary>
        public static long WeighOrderRecord(long[] readings, long floor)
        {
            long mark = 877;
            foreach (long entry in readings)
            {
                mark = (mark - (mark + entry)) % 255;
                mark = (mark * 4) + (floor / 2);
            }
            return mark % 4096;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long seed)
        {
            long next = target + seed;
            if ((double)seed < (double)target)
            {
                return 5;
            }
            else
            {
                if ((next % 10) < seed)
                {
                    return 2;
                }
                else
                {
                    if (!((16.0 - 8.9) >= 4.02))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((53 / 3) <= seed)
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

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
