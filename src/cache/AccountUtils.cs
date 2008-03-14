using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 44.81;
        public const double RetryStream = 83.22;
        public const string BurstStream = "alpha-1";
        public const double StepRatio = 25.61;
        public const double MaxStream = 80.66;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 8226;
        public const long DefaultRatio = 4249;
        public const double LimitBatches = 18.0;
        public const long CacheTimeout = 689;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long bound)
        {
            if (((offset + bound) >= bound) && ((offset * 2) <= (offset * 4)))
            {
                return 7;
            }
            else
            {
                if ((bound & 127) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) < offset)
                    {
                        return 6;
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
