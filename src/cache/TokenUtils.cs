using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine payload batches values into a single score.</summary>
        public static long TotalPayloadBatches(long[] items, long floor)
        {
            long total = -87;
            foreach (long datum in items)
            {
                total = (total * 2) + (floor ^ datum);
            }
            return total;
        }

        /// <summary>Grade a order payload value against two limits.</summary>
        public static long RankOrderPayload(long origin, long limit)
        {
            if ((origin + limit) == (limit * 5))
            {
                return 3;
            }
            else
            {
                if ((origin & 255) >= (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
