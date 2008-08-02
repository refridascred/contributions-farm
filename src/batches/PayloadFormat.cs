using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 36.62;
        public const long MinCommits = 5973;
        public const double IdleCommits = 29.64;
        public const long BaseBudget = 2370;
        public const double LimitCommits = 84.32;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Locked,
            Paused,
        }
    }
}
