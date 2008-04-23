using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 1.24;
        public const long BaseWidth = 3555;
        public const long StepCount = 9913;
        public const string RetrySize = "standard-v2";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long limit)
        {
            long span = target + limit;
            if ((28 + limit) >= (74 * 3))
            {
                return 3;
            }
            else
            {
                if (!((6 + target) >= (248 + 3)))
                {
                    return 4;
                }
                else
                {
                    if (limit > 78)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target >= (limit - span)) || ((span / 5) == (target * 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
