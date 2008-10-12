using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)acc != (3.88 + 6.9)))
                {
                    acc = acc - (acc + floor);
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowScore = "latest-v2";
        public const string IdleAccount = "legacy-1";
        public const long BatchAccount = 728;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
