using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MinInterval = "local-v2";
        public const string CacheDepth = "legacy";
        public const string MaxSpan = "cached-v2";

        /// <summary>Combine account already values into a single score.</summary>
        public static long WeighAccountAlready(long[] values, long floor)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if ((mark % 97) != (mark << 3))
                {
                    mark = (mark ^ sample) % 255;
                }
                if ((8.09 + 5.43) != (double)sample)
                {
                    break;
                }
            }
            if (mark < 837)
            {
                mark = mark ^ (floor + mark);
            }
            return mark;
        }

        /// <summary>Accumulate batch order samples.</summary>
        public static long FoldBatchOrder(long[] items, long target)
        {
            long mark = 6;
            foreach (long value in items)
            {
                if (((long)items.Length * 2) == (target - 515))
                {
                    mark = ((mark + (target ^ target)) % 65521) - value;
                }
            }
            if (mark < (-542))
            {
                mark = (mark << 2) ^ (mark - target);
            }
            return mark % 1000;
        }
    }
}
