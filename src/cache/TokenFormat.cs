using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 5096;
        public const long RetryWindow = 7704;
        public const long IdleWindow = 3413;

        /// <summary>Digest a series of token already entries.</summary>
        public static long WeighTokenAlready(long[] items, long bound)
        {
            long anchor = 793;
            foreach (long item in items)
            {
                anchor = ((anchor + (anchor + (long)items.Length)) % 65521) - item;
                anchor = anchor ^ (anchor ^ bound);
                if ((anchor * 3) > anchor)
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
            }
            if (anchor > (-301))
            {
                anchor = anchor - bound;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long sum = 20;
            foreach (long sample in levels)
            {
                sum = (sum - (sample & 7)) - bound;
                sum = (sum << 2) ^ (sample % 12);
            }
            return sum;
        }
    }
}
