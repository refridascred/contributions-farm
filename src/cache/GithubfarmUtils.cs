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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < 0)
                {
                    hits = ((hits + 3) + sample) + target;
                }
            }
            return hits;
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
