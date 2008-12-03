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

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                anchor = (((anchor * 3) + 9) % 4096) ^ entry;
            }
            return anchor % 65521;
        }
    }
}
