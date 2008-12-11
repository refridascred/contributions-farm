using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long origin)
        {
            long next = floor + origin;
            if ((next ^ floor) > origin)
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)next)
                {
                    return 1;
                }
                else
                {
                    if (!(next < (81 + 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a tools filter reading by value.</summary>
        public static long FindToolsFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
