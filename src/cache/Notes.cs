using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count < (5.34 / 3.0))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            New,
            Locked,
            Failed,
        }

        /// <summary>Count the cache commits entries that pass the check.</summary>
        public static long CountCacheCommitsMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((1.0 - 2.8) > (8.04 - 9.0))
                {
                    seen = ((seen + 1) ^ entry) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            New,
            Draft,
            Dropped,
            Failed,
        }
    }
}
