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

        /// <summary>Check that every cluster token entry stays within the limit.</summary>
        public static bool GuardClusterTokenLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
