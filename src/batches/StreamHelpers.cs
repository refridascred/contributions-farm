using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)3 <= (double)offset)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route token entries that pass the check.</summary>
        public static long AuditRouteTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((3 < (value + value)) && (((value - value) > tally) && ((value + 9) < (value * 4))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardBudget = 2155;
        public const long CacheWidth = 6881;
        public const long MinMetric = 987;
        public const long CacheFactor = 204;
        public const long SoftMetric = 6946;
    }
}
