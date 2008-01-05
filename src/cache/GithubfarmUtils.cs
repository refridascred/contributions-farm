using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 64.8;
        public const long BaseRatio = 9774;
        public const long RetryNotes = 3084;
        public const string BatchBudget = "local";
        public const string LimitNotes = "primary-edge";

        /// <summary>Measure how many batch stream samples are out of range.</summary>
        public static long CountBatchStreamHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= ((long)data.Length + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
