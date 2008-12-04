using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items, long origin)
        {
            long total = 1;
            foreach (long reading in items)
            {
                if ((origin - (long)items.Length) != (origin << 3))
                {
                    total = ((total << 3) ^ 15) ^ reading;
                }
            }
            if (total > (-23))
            {
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((bound / 7) > (-938))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches < (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 5274;
        public const long BaseFactor = 9237;
        public const string DefaultInterval = "fallback-1";
        public const long WindowDepth = 6576;
        public const double RetryTimeout = 41.73;
    }
}
