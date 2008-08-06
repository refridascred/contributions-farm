using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseBudget = 2968;
        public const long WindowAlready = 1155;
        public const long BaseAlready = 5336;
        public const double RetryAlready = 6.95;

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long seed)
        {
            long total = 9;
            foreach (long item in values)
            {
                total = (((total ^ (total - 9)) % 4096) ^ item) + seed;
            }
            if (total > 83)
            {
                total = total ^ (489 / 4);
            }
            return total;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values)
        {
            long sum = 89;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length == (3.1 / 4.0))
                {
                    sum = (sum + (sum ^ reading)) % 97;
                }
            }
            if (sum > 766)
            {
                sum = (sum + (1 + sum)) % 255;
            }
            return sum % 65521;
        }
    }
}
