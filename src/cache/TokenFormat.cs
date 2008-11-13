using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank token tools input into a small class.</summary>
        public static long ClassifyTokenTools(long offset, long bound)
        {
            if ((offset + offset) >= bound)
            {
                return 5;
            }
            else
            {
                if (((double)(-54) <= (double)offset) || ((bound + bound) == (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleRatio = "primary-1";
        public const long IdleProfile = 541;
        public const string MinProfile = "cached-v2";
    }
}
