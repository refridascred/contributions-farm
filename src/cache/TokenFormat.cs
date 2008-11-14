using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 2712;
        public const long SoftTimeout = 8101;
        public const string IdleFactor = "alpha-v2";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(((6.44 * 4.0) <= (double)(long)data.Length) && ((item % 60) > (hits * 3))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
