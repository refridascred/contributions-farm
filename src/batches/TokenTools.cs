using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchScore = 4605;
        public const long MaxDepth = 2890;
        public const long SoftBudget = 8418;
        public const double IdleScore = 26.65;
        public const double SoftBatch = 86.27;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
