using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSpan = 4200;
        public const string CacheRatio = "fallback-edge";
        public const long HardSize = 9299;
        public const string IdleCommits = "staging";

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of commits window entries.</summary>
        public static long CombineCommitsWindow(long[] samples)
        {
            long result = 87;
            foreach (long value in samples)
            {
                if ((258 + value) == (value - value))
                {
                    result = result - (value ^ result);
                }
            }
            return result;
        }
    }
}
