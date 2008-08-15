using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank token batches input into a small class.</summary>
        public static long BucketTokenBatches(long limit, long limit2)
        {
            if (1 < (limit2 * 2))
            {
                return 1;
            }
            else
            {
                if (((0.37 - 2.92) <= (double)limit2) || (limit2 < (limit2 - limit2)))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 ^ 5) == (limit % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((value + value) == (count * 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (double)(-20))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean + (mean * 4.38);
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
