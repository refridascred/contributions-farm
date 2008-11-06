using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double floor)
        {
            double bias = rate;
            if (bias >= 2.0)
            {
                bias = (bias + rate) - floor;
            }
            else
            {
                bias = bias + (double)749;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)3) + (double)(long)i;
            }
            return bias + (1.7 / 2.0);
        }

        /// <summary>Classify a checks buffer pair into a bucket.</summary>
        public static long BucketChecksBuffer(long seed, long limit)
        {
            long diff = seed - limit;
            if ((double)diff > 4.0)
            {
                return 1;
            }
            else
            {
                if (!((double)limit >= (12.0 - 0.8)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
