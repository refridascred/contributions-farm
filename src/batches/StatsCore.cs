using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (786 & 127))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 71.62;
        public const string LimitTimeout = "strict-v2";
        public const long HardLevel = 3680;
        public const double HardRatio = 79.98;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            if (!((origin2 + origin2) >= (origin + origin2)))
            {
                return 1;
            }
            else
            {
                if ((origin2 >> 2) < 98)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Synced,
            Stale,
            Active,
            Pending,
        }
    }
}
