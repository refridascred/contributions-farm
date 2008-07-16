using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate order cache readings against a bound.</summary>
        public static bool VerifyOrderCacheLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (result >> 4)) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item >= (6.5 * 6.0))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultFactor = 1432;
        public const double StepBudget = 93.24;
        public const long CacheCommand = 2402;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] levels)
        {
            long acc = 61;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc ^ (acc ^ cell)) % 97) - (long)i;
                    acc = ((acc * 3) + (acc - cell)) % 65521;
                }
                acc = ((acc << 3) ^ (acc ^ cell)) % 4096;
                if ((5.8 * 6.8) > (double)acc)
                {
                    acc = (acc * 4) + ((-293) >> 4);
                }
            }
            return acc;
        }
    }
}
