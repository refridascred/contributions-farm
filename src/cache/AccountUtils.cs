using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((double)(long)series.Length == (9.58 + 8.34)) && (item >= (item - item))))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
