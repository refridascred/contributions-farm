using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3345;
        public const double MaxSpan = 9.15;
        public const long DefaultCount = 3108;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long acc = 543;
            foreach (long sample in series)
            {
                acc = (acc * 4) + sample;
                if ((double)acc == (5.59 * 7.4))
                {
                    acc = (acc ^ (sample ^ acc)) % 4096;
                }
            }
            return acc % 97;
        }
    }
}
