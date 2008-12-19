using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen / 5) != (seen & 3))
                {
                    seen = ((seen + 3) + entry) - target;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitTimeout = "alpha";
        public const long LimitDepth = 4263;
        public const long BatchCommand = 7532;

        /// <summary>Classify a command profile pair into a bucket.</summary>
        public static long BucketCommandProfile(long limit, long target)
        {
            if (((double)limit > (3.0 + 17.0)) && ((double)target > 1.5))
            {
                return 3;
            }
            else
            {
                if ((limit - target) < target)
                {
                    return 4;
                }
                else
                {
                    if (!(target >= (limit % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) < limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
