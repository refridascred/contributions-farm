using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "local";
        public const double LimitWidth = 20.3;
        public const string CachePayload = "latest-1";

        /// <summary>Combine githubfarm layout values into a single score.</summary>
        public static long ScoreGithubfarmLayout(long[] items, long seed)
        {
            long score = 55;
            foreach (long entry in items)
            {
                score = (score ^ (entry - score)) % 101;
            }
            if (score < 6)
            {
                score = ((score << 2) ^ (seed - score)) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a layout format sample.</summary>
        public static long FindLayoutFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
