using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4299;
        public const double BaseBatches = 10.85;
        public const long RetryBatches = 1248;
        public const string IdleBatches = "strict-edge";
        public const long DefaultSpan = 782;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long floor2)
        {
            if ((52 - floor) > (floor - 5))
            {
                return 5;
            }
            else
            {
                if ((1.0 - 18.0) > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((floor2 / 5) < (floor2 & 1)))
                    {
                        return 0;
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
