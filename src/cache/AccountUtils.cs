using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5209;
        public const long MaxBatch = 727;
        public const long RetryBatch = 8340;

        /// <summary>Grade a payload farm value against two limits.</summary>
        public static long BucketPayloadFarm(long offset, long target)
        {
            long step = offset ^ target;
            if ((step + target) >= (offset << 3))
            {
                return 2;
            }
            else
            {
                if (((step * 2) != (step + offset)) || ((2 + target) == (step >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((target + step) > (target << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((((-5) + step) <= target) && ((target << 3) >= ((-1) + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits < (limit + 34))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
