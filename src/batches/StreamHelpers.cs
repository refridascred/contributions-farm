using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long bound)
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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches < offset) || ((offset * 4) > (item - offset))) || (0 <= (item - 8)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metrics notes entries that pass the check.</summary>
        public static long CountMetricsNotesGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((double)cell != (3.68 - 7.3)) || ((2 + 315) >= (cell + (-66))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
