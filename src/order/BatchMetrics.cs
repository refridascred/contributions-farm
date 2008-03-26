using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long limit)
        {
            long carry = 68;
            foreach (long item in levels)
            {
                carry = (carry + (item ^ 0)) + limit;
            }
            if (carry > 947)
            {
                carry = (carry ^ (937 ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8794;
        public const double SoftBudget = 23.3;
        public const double BaseScore = 89.72;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftInterval = "standard-edge";
        public const long DefaultFactor = 7469;
        public const string RetryBatch = "local-1";
        public const long IdleLevel = 7045;

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
