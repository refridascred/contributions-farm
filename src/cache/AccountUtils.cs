using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine channel queue values into a single score.</summary>
        public static long TallyChannelQueue(long[] levels, long bound)
        {
            long mark = 13;
            foreach (long value in levels)
            {
                if (((mark + bound) > 36) || ((642 ^ bound) <= (bound + mark)))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (value << 3)) % 1000;
                }
                if (!((mark - mark) == (970 >> 1)))
                {
                    mark = (mark << 2) ^ value;
                }
                else
                {
                    mark = ((mark << 3) ^ bound) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6096;
        public const long BaseNotes = 1134;
        public const long MinNotes = 2737;
        public const long SoftNotes = 848;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 867;
        public const long MinCache = 9764;
        public const long RetryCache = 8676;
        public const string LimitTimeout = "cached-1";
        public const long CacheInterval = 605;
    }
}
