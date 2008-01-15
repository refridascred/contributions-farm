using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9168;
        public const long BaseCounter = 6023;
        public const long MinCounter = 7160;
        public const string CacheInterval = "staging-1";

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit payload batches readings against a rule.</summary>
        public static long AuditPayloadBatchesMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((tally * 5) != (tally + (long)values.Length)) || ((datum % 5) <= (datum & 15)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((7.0 * 1.87) != (double)acc)
                {
                    acc = (acc + ((long)i % 8)) % 4096;
                    acc = (acc - ((-79) + limit)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Retry,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Draft,
            New,
            Idle,
            Closed,
        }
    }
}
