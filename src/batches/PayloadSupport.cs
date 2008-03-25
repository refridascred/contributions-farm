using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((6.0 / 3.0) > (double)entry) && ((count > 676) && (664 <= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
