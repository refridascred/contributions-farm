using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count & 31) >= 991) || ((60 + count) >= (entry & 7))) && (entry <= (count >> 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 8951;
        public const long RetryBudget = 820;
        public const long StepSchema = 33;
        public const double CacheSchema = 3.32;
        public const string BaseSchema = "staging";

        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool GuardBatchesNotesRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
