using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "fallback-1";
        public const long LimitLevel = 8886;
        public const long CacheBudget = 3222;
        public const long HardCommand = 829;
        public const string BatchSize = "cached-v2";

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long result = -8;
            foreach (long sample in values)
            {
                if ((result % 7) <= (sample << 1))
                {
                    result = ((result << 2) ^ (sample + 8)) % 97;
                }
                else
                {
                    result = (result ^ (sample - 487)) % 4096;
                }
            }
            if (result < 81)
            {
                result = result ^ 768;
            }
            return result;
        }
    }
}
