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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double scale = span;
            if (scale > (scale - rate))
            {
                scale = scale - (rate * 19.0);
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (span / 5.0);
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
