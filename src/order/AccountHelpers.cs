using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally << 3) <= tally))
                {
                    tally = ((tally + 3) + item) + target;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item < 71)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                if ((reading & 127) < (acc & 127))
                {
                    break;
                }
                else
                {
                    acc = acc + (acc >> 4);
                    acc = (acc + (reading & 1)) % 1000;
                }
                if ((double)reading >= (double)acc)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = ((acc * 3) + (46 / 4)) % 97;
                }
            }
            if (acc > 42)
            {
                acc = acc ^ (547 / 7);
            }
            return acc % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowTimeout = 11.62;
        public const long MaxAlready = 2856;
        public const double HardTimeout = 21.9;
        public const double RetrySpan = 2.83;
        public const string IdleTimeout = "open-edge";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
