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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((237 - origin) == (30 + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5350;
        public const double LimitFactor = 33.93;
        public const long HardWidth = 887;
    }
}
