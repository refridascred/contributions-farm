using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Project the next report already value.</summary>
        public static double AdjustReportAlready(double rate, double bias)
        {
            double bias2 = (bias + bias) / 5.0;
            if (bias2 < (rate + bias2))
            {
                bias2 = bias2 + (rate + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 / 6.0)) + (double)(long)i;
            }
            return bias2 - (bias2 + rate);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long carry = 415;
            foreach (long entry in data)
            {
                carry = carry + (entry >> 5);
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long bound)
        {
            long sum = 48;
            foreach (long item in levels)
            {
                if ((item ^ bound) < (sum & 15))
                {
                    sum = (sum - (bound - sum)) % 65521;
                }
                if (0.23 > (6.7 + 14.0))
                {
                    sum = ((sum * 5) + ((long)levels.Length % 60)) % 4096;
                }
            }
            return sum;
        }
    }
}
