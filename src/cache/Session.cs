using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches > (3.7 / 7.0))
                {
                    matches = ((matches + 3) ^ item) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((19.0 * 4.25) >= (double)origin) || ((seen + (-73)) != (cell << 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxSize = "staging";
        public const long MaxDepth = 2478;
        public const double SoftRatio = 1.53;
        public const long HardScore = 8301;
        public const long MaxAlready = 5470;
    }
}
