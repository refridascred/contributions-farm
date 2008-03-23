using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every record route entry stays within the limit.</summary>
        public static bool CheckRecordRouteLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit schema record readings against a rule.</summary>
        public static long CountSchemaRecordHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((4.5 / 2.0) <= (double)hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryRatio = 95.03;
        public const long MaxDepth = 396;
        public const double BaseBudget = 11.78;
        public const string CacheSize = "legacy";
        public const long BaseBatch = 1141;
    }
}
