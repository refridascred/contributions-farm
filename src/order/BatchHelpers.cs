using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7605;
        public const long BaseQueue = 5145;
        public const string HardQueue = "standard-v2";
        public const long BurstDepth = 2037;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "strict-edge";
        public const long LimitScore = 3870;
        public const double BatchGraph = 14.48;
        public const string MinFactor = "cached-v2";
        public const long CacheGraph = 7950;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long target, long bound)
        {
            long bound2 = target - bound;
            if (bound2 >= (657 ^ target))
            {
                return 0;
            }
            else
            {
                if ((target / 8) > (58 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound == (9.8 / 3.0)))
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
}
