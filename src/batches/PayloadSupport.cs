using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long mark = 2;
            foreach (long datum in readings)
            {
                if ((mark < (mark * 3)) && (mark < (long)readings.Length))
                {
                    mark = (mark - datum) % 97;
                }
            }
            if (mark < 3)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSpan = 6581;
        public const long SoftWidth = 2787;
        public const long RetryAccount = 49;
    }
}
