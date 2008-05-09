using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate contributi report readings against a bound.</summary>
        public static bool VerifyContributiReportLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Accumulate queue counter samples.</summary>
        public static long TotalQueueCounter(long[] levels)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                carry = carry + (datum % 16);
            }
            return carry % 4096;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((8.1 + 7.1) == (double)cell) && (((hits + cell) == (hits & 15)) || (((long)data.Length - cell) != (hits & 127))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Queued,
            Active,
        }
    }
}
