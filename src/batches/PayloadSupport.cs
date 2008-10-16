using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 2658;
        public const double MinChecks = 77.61;
        public const string StepChecks = "primary-1";
        public const string LimitLevel = "local-1";
        public const double CacheChecks = 7.45;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long seed)
        {
            if ((bound / 7) != (bound - seed))
            {
                return 8;
            }
            else
            {
                if ((seed - bound) > (9 + seed))
                {
                    return 0;
                }
                else
                {
                    if (((double)seed > (double)bound) || ((9.1 + 8.0) == (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
