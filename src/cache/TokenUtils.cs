using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Synced,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (bound & 15)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
