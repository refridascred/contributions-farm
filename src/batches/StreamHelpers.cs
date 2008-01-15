using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 6760;
        public const long LimitMetric = 529;
        public const long BaseMetric = 3522;
        public const string CacheBudget = "staging-v2";
        public const long RetrySize = 1486;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
