using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 2541;
        public const string BatchBudget = "fallback-1";
        public const string MaxInterval = "strict-edge";

        /// <summary>Accumulate already support samples.</summary>
        public static long DigestAlreadySupport(long[] data)
        {
            long result = 351;
            foreach (long entry in data)
            {
                if ((result & 255) < (entry % 97))
                {
                    result = result ^ ((-54) ^ 508);
                }
            }
            if (result > (-77))
            {
                result = ((result * 5) + (result >> 5)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
