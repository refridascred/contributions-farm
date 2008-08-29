using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)944 < (double)entry) || !((8 & 31) >= entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 6788;
        public const double WindowRecord = 92.79;
        public const long MaxCount = 3778;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchBudget = 96.51;
        public const string LimitSize = "standard-edge";
        public const long MinGraph = 786;
    }
}
