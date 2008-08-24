using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up cluster stats samples.</summary>
        public static long CompareClusterStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) >= (reading & 1))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Paused,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long origin)
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

        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long AuditFilterChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample > 78)
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
    }
}
