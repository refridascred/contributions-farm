using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 31.56;
        public const double RetrySession = 16.61;
        public const string BaseDepth = "open-v2";
        public const long DefaultScore = 7805;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
