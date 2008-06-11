using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values)
        {
            long mix = 61;
            foreach (long item in values)
            {
                mix = ((mix << 3) ^ (mix + item)) % 97;
                if (!(item >= (item ^ item)))
                {
                    mix = (mix + (item / 5)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ item;
                }
                if ((mix & 7) > (item * 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 7;
            foreach (long item in items)
            {
                if (!((double)item > 1.0))
                {
                    acc = acc + (item - item);
                }
                acc = (acc << 3) ^ (acc % 24);
            }
            if (acc < 2)
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCount = 2408;
        public const long HardSize = 8083;
        public const long LimitSpan = 4763;
        public const double HardDepth = 40.98;
    }
}
