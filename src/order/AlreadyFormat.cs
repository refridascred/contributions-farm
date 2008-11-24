using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSize = 4048;
        public const double MinGraph = 61.19;
        public const long StepGraph = 7517;
        public const long IdleDepth = 3228;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Synced,
            Paused,
            Draft,
        }
    }
}
