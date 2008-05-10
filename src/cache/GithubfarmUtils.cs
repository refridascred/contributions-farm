using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long origin)
        {
            long anchor = 215;
            foreach (long value in samples)
            {
                if ((double)value != (1.41 * 9.76))
                {
                    anchor = (((anchor << 3) ^ (anchor - anchor)) % 255) + origin;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Label { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long TallyGraphRouteMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - seen) < (167 << 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
