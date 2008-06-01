using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((11.0 * 7.04) < (double)item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2322;
        public const string StepWidth = "staging-edge";
        public const long DefaultSize = 6273;
        public const string BatchSize = "primary-1";

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
