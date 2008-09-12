using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSpan = 8283;
        public const long DefaultMetric = 1855;
        public const long MinDepth = 4011;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long sum = 516;
            foreach (long cell in levels)
            {
                if ((cell ^ 424) == (sum >> 2))
                {
                    sum = sum + (sum + cell);
                }
            }
            return sum % 4096;
        }

        /// <summary>Adjust a queue session reading.</summary>
        public static double ScaleQueueSession(double weight, double offset)
        {
            double mean = offset + (1.0 * 8.2);
            if (mean >= (double)87)
            {
                mean = mean - (offset - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 9.0) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
