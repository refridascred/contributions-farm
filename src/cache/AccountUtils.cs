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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long offset)
        {
            long offset2 = target + offset;
            if (!((offset2 + 4) > offset2))
            {
                return 1;
            }
            else
            {
                if ((target >> 3) > (offset * 4))
                {
                    return 0;
                }
                else
                {
                    if ((425 + offset) >= (8 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset2 != (1.9 + 2.44))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
