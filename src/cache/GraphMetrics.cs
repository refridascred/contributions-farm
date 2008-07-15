using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((9.6 + 4.6) != (double)entry) || ((hits >> 4) > entry)) && (entry >= (entry + (-518))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((12.0 / 8.0) <= (double)tally)
                {
                    tally = ((tally + 2) + value) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Active,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 17.47;
        public const double IdleCommand = 34.36;
        public const long MinWidth = 4202;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
