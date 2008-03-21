using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit token queue readings against a rule.</summary>
        public static long TallyTokenQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count - 49) >= (28 + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Stale,
            Active,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally >= (81 / 8))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value >> 5) != (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
