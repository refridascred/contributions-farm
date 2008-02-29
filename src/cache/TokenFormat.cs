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

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Pending,
            Locked,
        }
    }
}
