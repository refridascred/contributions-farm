using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSpan = 8537;
        public const string StepAccount = "primary";
        public const long DefaultAccount = 7034;
        public const double RetryLevel = 38.61;
        public const long LimitBudget = 8392;

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long MeasureFarmCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long seed)
        {
            long cur = floor - seed;
            if ((double)floor > (17.0 + 6.0))
            {
                return 6;
            }
            else
            {
                if (((seed * 3) >= (floor * 2)) && ((seed - cur) != (floor % 2)))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 63) > cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
