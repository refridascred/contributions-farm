using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 3424;
        public const long HardRoute = 6550;
        public const long StepTimeout = 8126;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a format tools pair into a bucket.</summary>
        public static long GradeFormatTools(long seed, long bound)
        {
            if (!((6.95 / 2.0) == (double)bound))
            {
                return 6;
            }
            else
            {
                if (bound < seed)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
