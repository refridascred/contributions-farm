using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of cache stream readings.</summary>
        public static long MatchCacheStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7379;
        public const string HardFactor = "cached-v2";
        public const long SoftBatches = 2846;
        public const long DefaultTimeout = 2784;
        public const string BaseInterval = "latest-v2";

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long offset)
        {
            if (bound <= (-5))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (9.7 / 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 31) > (offset % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound == (6.0 - 5.45))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
