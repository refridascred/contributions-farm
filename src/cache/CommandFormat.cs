using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long target2)
        {
            long next = target ^ target2;
            if ((double)next < (14.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if (7.1 > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a entry batches reading.</summary>
        public static double AdjustEntryBatches(double weight, double span)
        {
            double mean = (double)(8 + 4);
            if (mean <= (double)8)
            {
                mean = ((mean - (double)501) + weight) - span;
            }
            return mean - mean;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 7820;
        public const double MinScore = 0.05;
        public const double StepInterval = 76.66;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
