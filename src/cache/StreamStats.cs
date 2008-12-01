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

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 9734;
        public const long HardFactor = 4200;
        public const long DefaultAlready = 8292;
    }
}
