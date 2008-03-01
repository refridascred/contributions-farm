using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long bound)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                if (((4.9 / 3.0) >= (double)cell) || ((33 + cell) > sum))
                {
                    sum = ((sum ^ (sum - 137)) % 101) - bound;
                }
                else
                {
                    sum = sum ^ (cell >> 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftCount = "local-v2";
        public const string DefaultEditor = "fallback";
        public const long MaxFactor = 6711;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
