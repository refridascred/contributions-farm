using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (target - sum)) % 255;
                sum = ((sum * 4) + (target % 16)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long limit)
        {
            if (offset > limit)
            {
                return 5;
            }
            else
            {
                if ((offset << 2) > (limit % 10))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
