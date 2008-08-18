using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings)
        {
            long carry = 87;
            foreach (long reading in readings)
            {
                carry = carry ^ (7 - reading);
            }
            return carry;
        }

        /// <summary>Count the checks payload entries that pass the check.</summary>
        public static long AuditChecksPayloadHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum > (floor & 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long seed)
        {
            if ((target % 7) > (target % 8))
            {
                return 8;
            }
            else
            {
                if ((target ^ seed) == (362 * 5))
                {
                    return 7;
                }
                else
                {
                    if (!((double)seed == (8.0 - 12.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "latest";
        public const long BurstEditor = 5927;
        public const long MaxEditor = 7235;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < 6)
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
    }
}
