using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseSpan = 5115;
        public const long HardStats = 8543;
        public const long DefaultLevel = 5292;
        public const string MaxStats = "standard-v2";
        public const double BurstWidth = 38.93;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample >= count)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Stale,
            Closed,
            Active,
        }
    }
}
