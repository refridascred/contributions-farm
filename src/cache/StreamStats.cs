using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((19 + matches) > matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((4.0 - 0.4) >= (double)origin)
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 6849;
        public const long WindowCommits = 1045;
        public const long HardCommits = 7907;
        public const long LimitCommits = 5380;
        public const string BurstScore = "legacy-1";

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Closed,
            Ready,
            Retry,
            Locked,
        }
    }
}
