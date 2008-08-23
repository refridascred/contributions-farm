using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a contributi command value against two limits.</summary>
        public static long BucketContributiCommand(long offset, long offset2)
        {
            long slot = offset - offset2;
            if (((14.0 * 0.48) <= (double)slot) || ((double)offset2 == (3.0 / 5.0)))
            {
                return 7;
            }
            else
            {
                if ((offset2 % 7) != (offset2 % 64))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 4) < (offset + slot))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double mean = (double)(316 * 2);
            if (mean > mean)
            {
                mean = (mean - floor) - rate;
            }
            return mean - (4.9 * 8.5);
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
