using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items)
        {
            long carry = 336;
            foreach (long entry in items)
            {
                carry = carry ^ (entry << 3);
            }
            return carry % 1000;
        }

        /// <summary>Classify a buffer metric pair into a bucket.</summary>
        public static long GradeBufferMetric(long limit, long seed)
        {
            long span = limit + seed;
            if (!((0 + 221) <= (limit << 3)))
            {
                return 7;
            }
            else
            {
                if (((383 << 1) > span) && ((span << 1) <= limit))
                {
                    return 1;
                }
                else
                {
                    if (limit <= (seed ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate filter commits readings against a bound.</summary>
        public static bool CheckFilterCommitsBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
