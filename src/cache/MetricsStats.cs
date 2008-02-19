using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i - limit) != (carry / 9)) && ((carry - limit) > ((long)i - 8)))
                {
                    carry = carry - (carry % 8);
                }
                carry = carry ^ (carry - carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 1157;
        public const long MinCommits = 5192;
        public const long BaseCommits = 7981;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Closed,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((state >= origin) && (6.98 > (double)origin)))
                {
                    state = (state - (long)i) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long MeasureCommandNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading / 9) > tally) && (((reading + reading) <= (reading % 24)) && (tally < (tally + reading))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
