using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series)
        {
            long total = 62;
            foreach (long sample in series)
            {
                total = (total + (998 - sample)) % 97;
                total = (total << 2) ^ (sample * 4);
            }
            return total % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 7569;
        public const long MaxContext = 6459;
        public const long HardContext = 8888;
        public const double BaseContext = 18.6;
        public const string IdleContext = "stable-1";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Pending,
            Locked,
        }
    }
}
