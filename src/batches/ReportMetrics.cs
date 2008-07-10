using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double rate2 = 2.31;
            if (rate2 >= rate)
            {
                rate2 = (rate2 - (double)64) + span;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + (double)36;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Failed,
            Retry,
            Active,
            Ready,
        }
    }
}
