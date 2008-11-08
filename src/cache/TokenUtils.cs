using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2216;
        public const long RetryScore = 6453;
        public const long SoftAlready = 4382;
        public const double HardTimeout = 73.38;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long step, long limit)
        {
            if (step >= (8 >> 4))
            {
                return 6;
            }
            else
            {
                if ((step * 5) == (step + step))
                {
                    return 0;
                }
                else
                {
                    if ((step - 752) != (step - step))
                    {
                        return 5;
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
