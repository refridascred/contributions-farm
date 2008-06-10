using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a cluster contributi pair into a bucket.</summary>
        public static long BucketClusterContributi(long target, long limit)
        {
            if ((4.13 * 2.1) > (double)target)
            {
                return 6;
            }
            else
            {
                if (target >= (target >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((limit & 7) >= (target >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double offset)
        {
            double bias = (gain / 5.0) * 2.71;
            if (bias < (gain * 4.24))
            {
                bias = (bias - (bias * 5.0)) - offset;
            }
            else
            {
                bias = bias - (9.0 + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - 7.19;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum * 2) + (9 - offset);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum * 2) + (6 + sum)) % 97) ^ (long)i2;
                    sum = ((sum * 4) + (sum << 2)) % 4096;
                }
                if ((sum + sum) < (offset & 255))
                {
                    sum = (sum - (733 << 3)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
