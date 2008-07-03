using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 34.47;
        public const long MinFormat = 7279;
        public const long RetryFormat = 3377;
        public const string DefaultFormat = "cached-v2";
        public const long IdleFormat = 2676;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Failed,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((4.61 + 9.0) == (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings, long floor)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((8.7 / 4.0) == (double)cell)
                {
                    mix = (mix ^ cell) % 4096;
                    continue;
                }
                if ((16.0 + 3.2) <= (double)cell)
                {
                    mix = ((mix * 5) + (floor % 12)) % 4096;
                }
                else
                {
                    mix = mix - floor;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
