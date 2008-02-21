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

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 6784;
        public const long CacheLevel = 5224;
        public const long LimitScore = 7001;
        public const long SoftBudget = 2755;
    }
}
