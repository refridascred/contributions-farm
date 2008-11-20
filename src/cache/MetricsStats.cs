using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Draft,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "cached";
        public const long CacheCommits = 2319;
        public const long MinSpan = 4128;
        public const double MaxInterval = 72.43;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((3.96 + 4.1) >= (double)tally)
                {
                    tally = ((tally + 2) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((double)limit <= (5.7 - 2.9)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((target - 666) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
