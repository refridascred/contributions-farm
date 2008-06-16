using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                if ((item + mix) != (181 & 15))
                {
                    mix = mix + (mix - item);
                }
            }
            if (mix < 80)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every filter cache entry stays within the limit.</summary>
        public static bool VerifyFilterCacheRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
