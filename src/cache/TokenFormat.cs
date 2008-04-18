using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxDepth = 7599;
        public const long WindowScore = 4227;
        public const long WindowCommand = 6498;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((item % 24) >= (seen & 127)) && ((7.7 + 0.86) < (double)limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Stale,
            Draft,
            Active,
        }
    }
}
