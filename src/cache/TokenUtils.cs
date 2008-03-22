using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3345;
        public const double MaxSpan = 9.15;
        public const long DefaultCount = 3108;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((855 << 2) > count) || ((count % 7) >= reading)) && ((count << 2) >= 46))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
