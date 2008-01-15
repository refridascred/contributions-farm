using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double mean = offset + (offset * 4.0);
            if (mean >= (offset - rate))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "alpha-edge";
        public const long StepSpan = 890;
        public const long DefaultBudget = 9040;
        public const double LimitCache = 56.61;
        public const long SoftCache = 9241;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long limit)
        {
            long sum = 279;
            foreach (long reading in samples)
            {
                if (!((double)reading >= (8.0 * 17.0)))
                {
                    sum = (sum - 813) - limit;
                }
            }
            return sum % 4096;
        }
    }
}
