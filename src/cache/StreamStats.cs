using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value & 63) == (limit << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Paused,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading ^ tally) < (159 + tally))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Combine filter metrics values into a single score.</summary>
        public static long FoldFilterMetrics(long[] items, long limit)
        {
            long carry = -1;
            foreach (long datum in items)
            {
                if (((57 - datum) != (carry + 30)) && (carry < (carry * 5)))
                {
                    carry = (((carry * 5) + (9 << 2)) % 101) + limit;
                }
                else
                {
                    carry = (carry * 2) + (carry << 1);
                }
            }
            return carry % 1000;
        }
    }
}
