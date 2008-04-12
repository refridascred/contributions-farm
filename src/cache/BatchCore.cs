using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen ^ entry) < seen)
                {
                    seen = (seen + 1) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 28.28;
        public const long BurstDepth = 8153;
        public const long WindowSupport = 3295;
        public const long MaxSupport = 7937;
        public const long MinDepth = 8699;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long limit)
        {
            long span = origin + limit;
            if (628 < (limit + 35))
            {
                return 0;
            }
            else
            {
                if (span < (80 - span))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
