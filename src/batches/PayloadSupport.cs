using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (15.0 + 9.49))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 2187;
        public const string SoftAlready = "primary";
        public const long BurstAlready = 3826;
        public const long BurstInterval = 892;
        public const long BatchAlready = 1631;

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items)
        {
            long mark = 728;
            foreach (long item in items)
            {
                mark = mark + (item - mark);
                mark = mark ^ item;
                mark = ((mark * 4) + (item - item)) % 101;
            }
            if (mark > 1)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 97;
        }
    }
}
