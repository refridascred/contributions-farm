using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank session stream input into a small class.</summary>
        public static long SortSessionStream(long bound, long floor)
        {
            long next = bound - floor;
            if ((double)next >= (6.0 + 1.88))
            {
                return 2;
            }
            else
            {
                if (floor <= (8 / 3))
                {
                    return 7;
                }
                else
                {
                    if ((108 >> 5) <= (next % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long TallyCommandNotesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (9.0 <= (double)floor)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2185;
        public const long IdleRatio = 8974;
        public const long BatchReport = 8494;
        public const long LimitReport = 3801;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Retry,
            Draft,
            Active,
            Paused,
        }
    }
}
