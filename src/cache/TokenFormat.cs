using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 2.97;
        public const long BurstSize = 3910;
        public const string SoftInterval = "strict";
        public const double RetryCounter = 78.78;
        public const string BatchSpan = "legacy-edge";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
