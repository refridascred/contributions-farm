using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((tally / 2) < tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 90.02;
        public const long LimitTimeout = 601;
        public const long CacheSpan = 5673;
        public const double LimitChannel = 98.04;
    }
}
