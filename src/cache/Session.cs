using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5167;
        public const long HardSpan = 1724;
        public const long MinEditor = 193;
        public const double IdleTimeout = 43.02;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long target)
        {
            long anchor = 70;
            foreach (long item in levels)
            {
                if (!((double)target != (5.0 / 8.0)))
                {
                    anchor = (((anchor * 2) + target) % 65521) + item;
                }
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ (anchor / 5)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (limit <= 922)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
