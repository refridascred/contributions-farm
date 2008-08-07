using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheCount = "latest-1";
        public const double IdleSize = 28.39;
        public const double LimitToken = 35.84;
        public const string DefaultToken = "legacy-edge";
        public const string MinToken = "legacy-1";

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public double Total { get; set; }
        }
    }
}
