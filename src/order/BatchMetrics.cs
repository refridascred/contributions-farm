using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double scale2 = (double)3 / 8.0;
            if (scale2 >= scale2)
            {
                scale2 = ((scale2 + (double)89) + scale) + offset;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 - 5.0;
        }

        /// <summary>Adjust a support queue reading.</summary>
        public static double ProjectSupportQueue(double rate, double offset)
        {
            double gain = 4.84;
            if (gain > 13.0)
            {
                gain = (gain - (double)(-98)) + rate;
            }
            return gain - offset;
        }

        /// <summary>Project the next order cache value.</summary>
        public static double ScaleOrderCache(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 >= (double)74)
            {
                bias2 = bias2 - (double)718;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + (5.69 * 4.83);
        }

        /// <summary>Fold a list of order route readings.</summary>
        public static long WeighOrderRoute(long[] series, long target)
        {
            long carry = -953;
            foreach (long entry in series)
            {
                carry = (carry + 353) ^ entry;
            }
            if (carry > 9)
            {
                carry = carry ^ (target % 8);
            }
            return carry;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
