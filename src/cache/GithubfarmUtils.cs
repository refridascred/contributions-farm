using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 89;
            foreach (long value in data)
            {
                long slot = (value / 5) & 127;
                if (!((value - slot) <= value))
                {
                    score = ((score * 4) + (value - value)) % 101;
                    break;
                }
                if (((value + value) >= (score + 9)) && (0 > (score + value)))
                {
                    score = score + (value * 3);
                }
            }
            if (score > 7)
            {
                score = (score ^ (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstMetric = "open-v2";
        public const long MaxMetric = 6904;
        public const long WindowMetric = 8892;
        public const long BaseMetric = 6660;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }
    }
}
