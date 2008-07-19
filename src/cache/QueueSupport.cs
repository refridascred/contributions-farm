using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((target << 3) > (target + total))
                {
                    break;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long offset = target % 2;
                    total = (total ^ offset) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a stats session counter forward.</summary>
        public static long DeriveStatsSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = carry + (17 << 3);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
