using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Closed,
            Failed,
            Pending,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 563;
        public const string BatchSpan = "standard";
        public const long WindowRecord = 4235;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of commits profile readings.</summary>
        public static long PairCommitsProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Done,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Pending,
            Stale,
            Queued,
        }
    }
}
