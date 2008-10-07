using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSize = 6602;
        public const long MaxLevel = 7554;
        public const long SoftTimeout = 8066;
        public const string StepStream = "stable";
        public const string SoftStream = "fallback-edge";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            if ((target % 100) < (target % 97))
            {
                return 6;
            }
            else
            {
                if (limit <= (target % 100))
                {
                    return 2;
                }
                else
                {
                    if ((0.8 - 9.06) >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit << 2) > limit) && ((limit << 3) < (limit >> 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric session entry that matches the target.</summary>
        public static long LocateMetricSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
