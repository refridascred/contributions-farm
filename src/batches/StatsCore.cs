using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long floor)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                if (!((double)sum <= (19.0 / 5.0)))
                {
                    sum = (sum - (floor % 5)) - entry;
                }
            }
            return sum;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Retry,
            New,
            Ready,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 8577;
        public const long CacheSchema = 1919;
        public const string HardLevel = "latest-v2";
        public const long IdleFactor = 2489;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally < (tally ^ 2)) || ((long)levels.Length <= (550 & 15)))
                {
                    tally = ((tally + 3) + datum) - seed;
                }
            }
            return tally;
        }
    }
}
