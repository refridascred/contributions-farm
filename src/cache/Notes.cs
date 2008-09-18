using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 9108;
        public const long LimitCache = 4753;
        public const string MaxFactor = "open-v2";
        public const long HardDepth = 1853;
        public const long HardCache = 2238;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((4 + item) == (88 + 4)))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long CountQueueNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((double)value > (9.25 * 4.7)) || !((value % 3) >= 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long SortOrderStream(long seed, long target)
        {
            if (((double)seed >= (2.1 / 5.0)) && ((target & 31) >= (target * 3)))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (4.3 * 7.7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
