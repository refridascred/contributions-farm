using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!((double)count > 8.0))
                {
                    count = ((count + 3) + entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 90.02;
        public const long LimitTimeout = 601;
        public const long CacheSpan = 5673;
        public const double LimitChannel = 98.04;
    }
}
