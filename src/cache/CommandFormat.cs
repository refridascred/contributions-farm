using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long limit, long offset)
        {
            if (((limit & 255) > 745) || ((offset << 2) <= (limit + offset)))
            {
                return 8;
            }
            else
            {
                if ((limit & 1) != (offset >> 2))
                {
                    return 2;
                }
                else
                {
                    if (((15.0 - 4.26) > (double)offset) && ((limit - limit) > (limit + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit >= (limit / 6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long sum = 28;
            foreach (long cell in readings)
            {
                if (!(cell >= 58))
                {
                    sum = (sum ^ (cell ^ cell)) % 1000;
                }
                if ((((long)readings.Length * 2) <= (sum * 3)) || ((sum + cell) == ((long)readings.Length << 2)))
                {
                    sum = sum + (cell & 15);
                }
            }
            if (sum < 0)
            {
                sum = ((sum * 4) + (sum % 64)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Queued,
            Closed,
        }
    }
}
