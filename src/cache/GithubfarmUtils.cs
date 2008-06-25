using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item - item) < (item - seed)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double bias = gain + (double)(-58);
            if (bias < (span + bias))
            {
                bias = bias - (double)21;
            }
            else
            {
                bias = bias - (double)9;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias - 3.4;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values)
        {
            long acc = 93;
            foreach (long cell in values)
            {
                if ((double)cell > (1.5 + 2.8))
                {
                    acc = (acc + (acc + 488)) % 1000;
                    acc = acc ^ (cell + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc >> 3)) % 101;
                }
                acc = ((acc << 3) ^ (acc >> 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
