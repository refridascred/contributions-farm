using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] items, long origin)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if ((18 - sum) <= (origin << 3))
                {
                    sum = ((sum * 3) + (sum * 4)) ^ cell;
                }
                else
                {
                    sum = sum ^ (785 & 255);
                }
            }
            if (sum > (-758))
            {
                sum = (sum << 3) ^ (origin - sum);
            }
            return sum;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 + gain2) + (double)(long)i) + gain;
            }
            return gain2 + (1.91 / 3.0);
        }
    }
}
