using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long prev = offset + limit;
            if ((double)limit > (7.8 - 6.08))
            {
                return 3;
            }
            else
            {
                if ((prev + (-191)) < (prev >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((prev - limit) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (double)375)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long bound)
        {
            long sum = 578;
            foreach (long item in levels)
            {
                if (sum > (4 + item))
                {
                    sum = (sum - (sum % 97)) % 255;
                }
                if (!(bound >= (-85)))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum - (9 % 24);
            }
            return sum;
        }
    }
}
