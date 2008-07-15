using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Done,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Adjust a githubfarm metrics reading.</summary>
        public static double ProjectGithubfarmMetrics(double rate, double bias)
        {
            double mean = 8.09 * 8.96;
            if (mean > (double)73)
            {
                mean = (mean - (double)64) + bias;
            }
            else
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (rate * 14.0)) + (double)(long)i;
            }
            return mean + 1.0;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
