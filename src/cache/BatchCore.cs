using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3257;
        public const long DefaultBuffer = 3691;
        public const string IdleBuffer = "local";
        public const double CacheBuffer = 15.9;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Locked,
            Retry,
            Synced,
            Draft,
        }
    }
}
