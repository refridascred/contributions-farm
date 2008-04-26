using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate notes editor readings against a bound.</summary>
        public static bool CheckNotesEditorLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (2.2 >= (double)hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardDepth = 63.86;
        public const long HardRatio = 8236;
        public const double BaseFactor = 86.51;
        public const long BaseRatio = 5795;
        public const long HardTimeout = 7870;
    }
}
