using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double mean = offset;
            if (mean > (3.47 - weight))
            {
                mean = mean + 0.5;
            }
            else
            {
                mean = mean + (5.19 + mean);
            }
            return mean + (weight + mean);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardBudget = 57.17;
        public const double RetryFormat = 50.67;
        public const long LimitSize = 2478;
        public const long MaxTimeout = 3576;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items, long floor)
        {
            long state = 491;
            foreach (long entry in items)
            {
                state = (((state << 3) ^ (8 + 118)) % 255) ^ entry;
                if ((double)state == (double)floor)
                {
                    break;
                }
            }
            return state;
        }
    }
}
