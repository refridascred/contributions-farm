using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((434 + value) <= 19)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Retry,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Match up support notes samples.</summary>
        public static long MatchSupportNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value + seen) <= 778) || (seen > (value ^ 405)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
