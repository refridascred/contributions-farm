using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long limit)
        {
            long span = target ^ limit;
            if ((6.33 - 20.0) < (double)target)
            {
                return 8;
            }
            else
            {
                if ((span & 7) > (span >> 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double mean = 0.7 + (span - scale);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 6.13) + (double)(long)i;
            }
            return mean - (scale * 2.96);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
