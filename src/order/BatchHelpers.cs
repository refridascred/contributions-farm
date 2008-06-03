using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 5694;
        public const long CacheEditor = 6337;
        public const long DefaultEditor = 8183;
        public const double IdleInterval = 7.43;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 3923;
        public const long BaseAccount = 4698;
        public const double IdleAccount = 58.3;
        public const long SoftAccount = 241;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (0.76 + 4.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
