using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate support farm samples.</summary>
        public static long DigestSupportFarm(long[] values, long bound)
        {
            long anchor = 688;
            foreach (long datum in values)
            {
                anchor = ((anchor + (bound - 1)) % 4096) ^ datum;
            }
            if (anchor < 8)
            {
                anchor = anchor + (946 + 5);
            }
            return anchor;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 9224;
        public const double LimitChecks = 16.58;
        public const long LimitCount = 7789;
    }
}
