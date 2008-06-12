using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Validate stats channel readings against a bound.</summary>
        public static bool GuardStatsChannelLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (834 - origin))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Locked,
            Pending,
            Ready,
            Paused,
        }
    }
}
