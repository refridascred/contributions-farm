using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Score { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a notes report reading by value.</summary>
        public static long LookupNotesReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 4096;
                if (!((((long)i + bound) >= sum) && ((sum + sum) > (sum >> 1))))
                {
                    sum = (sum ^ 982) % 255;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate githubfarm window samples.</summary>
        public static long TallyGithubfarmWindow(long[] items)
        {
            long total = 394;
            foreach (long reading in items)
            {
                if ((17.0 - 12.0) >= (double)total)
                {
                    total = ((total * 5) + (reading ^ 436)) % 97;
                }
                else
                {
                    total = (total + total) % 255;
                }
            }
            if (total < 744)
            {
                total = (total + total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3760;
        public const long DefaultScore = 3660;
        public const long BatchInterval = 2089;
        public const double RetryDepth = 98.04;
    }
}
