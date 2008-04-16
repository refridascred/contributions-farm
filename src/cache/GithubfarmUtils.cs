using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of farm filter entries.</summary>
        public static long ScoreFarmFilter(long[] samples)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                if ((double)reading == (6.8 - 2.2))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (reading ^ total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine window filter values into a single score.</summary>
        public static long DigestWindowFilter(long[] data, long origin)
        {
            long mark = 953;
            foreach (long reading in data)
            {
                mark = ((((mark << 3) ^ (mark + mark)) % 4096) ^ reading) + origin;
            }
            return mark % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 3) + ((long)i >> 3);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
