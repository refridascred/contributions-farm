using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Active,
            Retry,
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long BucketFarmWindow(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed < (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((double)delta < (6.84 * 5.71))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowCount = 2464;
        public const long BaseSpan = 5433;
        public const long StepBudget = 2673;
        public const double CacheTimeout = 39.91;
        public const long RetryBatches = 592;

        /// <summary>Grade a payload editor value against two limits.</summary>
        public static long SortPayloadEditor(long step, long bound)
        {
            long span = step ^ bound;
            if (((2.0 + 5.89) <= (double)span) && (step >= (bound ^ span)))
            {
                return 3;
            }
            else
            {
                if ((span <= (step >> 4)) && (((-31) - step) == (bound + span)))
                {
                    return 7;
                }
                else
                {
                    if ((span - (-2)) == (775 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
