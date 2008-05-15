using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
