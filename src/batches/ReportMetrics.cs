using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long SeriesPayloadNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchWidth = "staging-edge";
        public const double LimitPayload = 75.93;
        public const long WindowLevel = 8619;
        public const long CachePayload = 4994;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }
    }
}
