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

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Pending,
            Retry,
            Queued,
            Draft,
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

        /// <summary>Derive the next cluster report value from a seed.</summary>
        public static long RollClusterReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!(acc >= (acc << 1)))
                {
                    acc = ((acc * 4) + (bound + bound)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
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
