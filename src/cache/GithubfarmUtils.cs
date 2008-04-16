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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long seed, long target)
        {
            if (!((double)seed > (1.3 - 0.4)))
            {
                return 5;
            }
            else
            {
                if ((9.11 * 8.0) < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
