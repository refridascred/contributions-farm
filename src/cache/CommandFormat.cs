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

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
