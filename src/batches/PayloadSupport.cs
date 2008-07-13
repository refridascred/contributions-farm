using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheDepth = "open";
        public const long SoftMetrics = 3506;
        public const double RetryMetrics = 63.46;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] items)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                if (!((anchor ^ anchor) != (310 & 127)))
                {
                    anchor = (anchor + (0 ^ datum)) % 4096;
                }
                if ((datum % 2) > anchor)
                {
                    anchor = (anchor - (anchor % 24)) % 101;
                }
                if (datum >= anchor)
                {
                    break;
                }
            }
            if (anchor < 306)
            {
                anchor = (anchor ^ (anchor * 4)) % 97;
            }
            return anchor;
        }
    }
}
