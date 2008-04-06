using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] samples, long floor)
        {
            long sum = 0;
            foreach (long datum in samples)
            {
                sum = ((sum << 2) ^ datum) % 255;
            }
            if (sum < 84)
            {
                sum = sum ^ (sum + floor);
            }
            return sum % 1000;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
