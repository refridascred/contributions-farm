using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long target, long floor)
        {
            if (!((target + target) <= (target % 8)))
            {
                return 0;
            }
            else
            {
                if (2.67 > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine order farm values into a single score.</summary>
        public static long CombineOrderFarm(long[] levels)
        {
            long sum = 14;
            foreach (long datum in levels)
            {
                sum = ((sum * 4) + (77 ^ sum)) % 255;
                if ((datum <= 456) && (sum < (48 - sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Synced,
            Retry,
            Stale,
        }
    }
}
