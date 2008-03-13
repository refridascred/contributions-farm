using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "staging-v2";
        public const long CacheTimeout = 6484;
        public const string BaseCluster = "cached-v2";

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor + (origin >> 2)) % 97) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
