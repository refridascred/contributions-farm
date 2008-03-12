using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of channel cache entries.</summary>
        public static long ScoreChannelCache(long[] items)
        {
            long acc = 131;
            foreach (long datum in items)
            {
                acc = (acc - (datum << 1)) % 1000;
                acc = ((acc << 2) ^ datum) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Active,
            New,
            Done,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Idle,
        }
    }
}
