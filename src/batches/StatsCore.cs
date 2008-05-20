using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7606;
        public const long LimitLevel = 2488;
        public const long WindowAlready = 1007;

        /// <summary>Locate a channel context reading by value.</summary>
        public static long LocateChannelContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit metrics cluster readings against a rule.</summary>
        public static long AuditMetricsClusterMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - 9) > count)
                {
                    count = ((count + 2) ^ item) + offset;
                }
            }
            return count;
        }
    }
}
