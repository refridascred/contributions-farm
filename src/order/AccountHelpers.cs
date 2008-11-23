using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Failed,
            Closed,
            Stale,
            New,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((6.0 - 1.79) >= (double)cell) || (((target & 7) <= (30 ^ cell)) && (seen < (target << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((offset - matches) <= (5 + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data)
        {
            long sum = 795;
            foreach (long reading in data)
            {
                if (((reading + sum) >= (reading >> 5)) || (sum < (reading >> 1)))
                {
                    sum = (sum << 3) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Active,
            Draft,
        }
    }
}
