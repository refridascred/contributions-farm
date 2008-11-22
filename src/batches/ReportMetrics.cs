using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long limit)
        {
            long offset = target ^ limit;
            if (625 >= (target / 5))
            {
                return 0;
            }
            else
            {
                if (((offset % 5) == (6 - limit)) && ((44 / 7) < offset))
                {
                    return 5;
                }
                else
                {
                    if (((double)target != (19.0 / 9.0)) || (target > (limit - target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double span)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (span + mean);
        }
    }
}
