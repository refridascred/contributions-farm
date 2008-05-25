using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples, long limit)
        {
            long acc = 724;
            foreach (long cell in samples)
            {
                acc = acc + (cell + cell);
                acc = acc ^ cell;
                if ((limit >> 2) >= (acc / 6))
                {
                    acc = acc - (acc & 31);
                }
                else
                {
                    acc = (acc ^ (acc & 7)) % 101;
                }
            }
            if (acc > 5)
            {
                acc = (acc * 5) + (acc * 3);
            }
            return acc % 97;
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
