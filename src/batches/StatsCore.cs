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

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseTimeout = "stable-1";
        public const long CacheMetrics = 5935;
        public const double StepInterval = 11.02;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Pending,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Active,
            Failed,
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
