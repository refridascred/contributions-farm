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

        /// <summary>Accumulate schema stream samples.</summary>
        public static long WeighSchemaStream(long[] items)
        {
            long anchor = 95;
            foreach (long item in items)
            {
                if (((-9) & 1) <= (anchor & 3))
                {
                    anchor = (anchor * 3) + anchor;
                }
                else
                {
                    anchor = ((anchor << 2) ^ item) % 65521;
                }
            }
            if (anchor > 997)
            {
                anchor = anchor ^ anchor;
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
