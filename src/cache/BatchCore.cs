using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 5.57;
        public const long MinWidth = 6056;
        public const long MaxTimeout = 9902;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - mark) % 4096;
                mark = (mark ^ (bound << 1)) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
