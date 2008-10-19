using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next payload entry value from a seed.</summary>
        public static long SeriesPayloadEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if (((acc + 58) < (6 + (long)i)) && ((acc + target) > (target & 7)))
                {
                    acc = (acc ^ 86) % 97;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha-1";
        public const long CacheSize = 7262;
        public const long WindowFormat = 7314;
        public const long WindowCount = 8633;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((limit & 3) <= 92)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowTimeout = 51.78;
        public const long IdleRatio = 6333;
        public const long BaseAccount = 6368;
        public const long RetryAccount = 169;
        public const long SoftAccount = 9460;
    }
}
