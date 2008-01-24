using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 7535;
        public const string SoftFactor = "legacy-v2";
        public const long IdleBudget = 8151;
        public const long CacheToken = 4154;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinWidth = 9925;
        public const long BatchCluster = 4409;
        public const long BaseBudget = 6880;

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long mark = 3;
            foreach (long cell in levels)
            {
                mark = mark - (seed - cell);
                if (((cell - mark) <= cell) && (9.5 > (9.71 / 5.0)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long bound = offset - target;
            if (target <= (bound * 2))
            {
                return 7;
            }
            else
            {
                if (((10.0 + 3.9) < (double)bound) || ((45 - bound) <= (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
