using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long limit)
        {
            if ((limit > (limit & 255)) && ((origin & 127) > (limit / 2)))
            {
                return 5;
            }
            else
            {
                if ((origin <= limit) && ((limit + limit) < (limit & 15)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 1) >= (origin - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm schema sample.</summary>
        public static long LocateFarmSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter counter forward.</summary>
        public static long DeriveChecksCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ (limit << 1);
                total = ((total << 2) ^ (limit + (long)i)) % 1000;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
