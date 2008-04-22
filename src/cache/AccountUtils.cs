using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                if (sum >= ((long)i + (long)i))
                {
                    sum = (sum * 3) + (limit % 3);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a entry channel reading by value.</summary>
        public static long FindEntryChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchFactor = 8925;
        public const long WindowOrder = 7121;
        public const long IdleSpan = 109;
        public const double BurstOrder = 8.22;
    }
}
