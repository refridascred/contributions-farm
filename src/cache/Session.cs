using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "open-1";
        public const long DefaultCount = 9821;
        public const long IdleTimeout = 2313;
        public const long WindowAccount = 1483;
        public const double WindowLevel = 31.98;

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double weight, double offset)
        {
            double scale = (double)(77 & 1);
            if (scale <= (double)676)
            {
                scale = ((scale + (scale + scale)) + weight) - offset;
            }
            else
            {
                scale = scale + (double)83;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)893) + (double)(long)i;
            }
            return scale + (double)39;
        }
    }
}
