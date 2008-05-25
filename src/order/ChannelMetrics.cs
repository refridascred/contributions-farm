using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of account filter readings.</summary>
        public static long TotalAccountFilter(long[] items)
        {
            long score = 656;
            foreach (long entry in items)
            {
                score = ((score << 2) ^ (score << 3)) - entry;
            }
            return score;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((19 ^ cell) > matches) && (((cell & 3) >= (matches % 16)) || (cell < (cell & 63))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
