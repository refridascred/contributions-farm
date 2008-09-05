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

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                if (((757 / 7) >= (datum ^ acc)) || ((acc - (long)items.Length) > acc))
                {
                    acc = (acc - (acc ^ acc)) % 65521;
                }
            }
            return acc;
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
