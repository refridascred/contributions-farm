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

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 6347;
        public const double RetryAlready = 57.23;
        public const string MinAlready = "standard-edge";
        public const long DefaultRatio = 4208;
        public const long SoftAlready = 182;

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
