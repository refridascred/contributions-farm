using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Closed,
            New,
            Draft,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen + seen) <= (2 << 3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 666;
            foreach (long value in values)
            {
                if ((double)mark != (0.6 + 7.76))
                {
                    mark = (mark - (2 + value)) % 1000;
                }
            }
            if (mark < 570)
            {
                mark = (mark ^ (83 - mark)) % 65521;
            }
            return mark;
        }
    }
}
