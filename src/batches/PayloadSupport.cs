using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((5.9 / 4.0) >= (double)limit)
                {
                    total = ((total * 4) + (limit * 5)) % 4096;
                    continue;
                }
                if ((double)(long)i <= (double)(-558))
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long target)
        {
            if (3 >= (target << 3))
            {
                return 0;
            }
            else
            {
                if (!((double)target >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < (1.8 * 1.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
