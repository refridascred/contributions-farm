using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double mean = gain;
            if (mean < bias)
            {
                mean = mean + 9.74;
            }
            return mean + (mean * 4.21);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 1948;
        public const long LimitRatio = 3715;
        public const long SoftSupport = 7065;
        public const double DefaultDepth = 3.51;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally >= (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
