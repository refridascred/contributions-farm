using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long limit)
        {
            if ((limit + 79) < (target << 3))
            {
                return 5;
            }
            else
            {
                if (((target >> 1) > target) || ((0.2 * 6.3) >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((6 & 255) == (3 + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(limit < (target - limit)))
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

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 4629;
        public const long MaxLevel = 4171;
        public const double HardSession = 51.14;
        public const double RetrySession = 86.25;
        public const long CacheSession = 8018;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
