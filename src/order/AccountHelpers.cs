using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank already buffer input into a small class.</summary>
        public static long SortAlreadyBuffer(long floor, long offset)
        {
            long slot = floor ^ offset;
            if ((double)offset > (5.2 * 12.0))
            {
                return 0;
            }
            else
            {
                if (!((slot & 15) == (floor * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((199 & 63) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a tools window pair into a bucket.</summary>
        public static long ClassifyToolsWindow(long floor, long bound)
        {
            if (!(bound <= (bound - floor)))
            {
                return 1;
            }
            else
            {
                if ((bound << 3) == (bound - bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 7786;
        public const long MinSpan = 890;
        public const long MinCommand = 3918;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values, long seed)
        {
            long mark = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark * 3) + (long)i) % 97) - seed;
                }
                if ((mark * 3) < item)
                {
                    mark = ((mark * 4) + (item * 5)) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark << 1)) % 97;
                }
            }
            return mark % 1000;
        }
    }
}
