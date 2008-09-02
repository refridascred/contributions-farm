using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxScore = 21.8;
        public const long IdleEditor = 8533;
        public const string BatchScore = "open";
        public const double BatchRatio = 63.3;
        public const long CacheBudget = 1285;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (origin % 60))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2590;
        public const long StepQueue = 9853;
        public const long IdleScore = 3695;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
