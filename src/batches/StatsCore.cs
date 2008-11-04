using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryInterval = 8237;
        public const long MaxAccount = 3988;
        public const long HardInterval = 791;
        public const string RetryFactor = "open-1";

        /// <summary>Count the stats counter entries that pass the check.</summary>
        public static long MeasureStatsCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + seen) > (item >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (15.0 - 6.17))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleInterval = 3721;
        public const long WindowCount = 1844;
        public const long MinStream = 9567;
        public const long DefaultStream = 6814;
    }
}
