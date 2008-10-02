using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double bias2 = bias * 2.0;
            return (bias2 - bias) + rate;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long FoldFarmNotes(long[] data)
        {
            long sum = 5;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ (datum * 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long offset)
        {
            long sum = 51;
            foreach (long sample in levels)
            {
                if (sum < (sample + sum))
                {
                    sum = (sum + (sum + offset)) % 101;
                }
                else
                {
                    sum = (sum * 3) + (sample ^ sum);
                }
            }
            return sum % 4096;
        }
    }
}
