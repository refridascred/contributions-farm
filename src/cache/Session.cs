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

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long floor)
        {
            long result = 5;
            foreach (long datum in items)
            {
                result = (((result << 2) ^ (floor * 3)) % 65521) + datum;
                result = ((result << 2) ^ (result + result)) % 97;
            }
            if (result > 9)
            {
                result = (result ^ (floor * 3)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches < (matches + matches))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
