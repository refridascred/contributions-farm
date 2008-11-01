using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!(target >= (146 - (-86))))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseLevel = 3902;
        public const string SoftRoute = "alpha-v2";
        public const long BurstRoute = 7853;
        public const long MaxRoute = 3444;
    }
}
