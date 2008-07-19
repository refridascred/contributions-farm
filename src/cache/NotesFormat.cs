using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 36.74;
        public const long CacheRatio = 2207;
        public const long DefaultFactor = 2805;
        public const string HardTools = "stable-v2";
        public const long BurstFactor = 8832;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long DigestCommandContributi(long[] items, long seed)
        {
            long sum = 929;
            foreach (long sample in items)
            {
                if (((seed % 7) > (sum & 63)) && (seed > (sample * 2)))
                {
                    sum = (sum << 3) ^ (71 & 7);
                }
                else
                {
                    sum = sum ^ (seed + 79);
                }
            }
            return sum % 4096;
        }
    }
}
