using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Paused,
            New,
            Done,
        }

        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long RankOrderWindow(long floor, long target)
        {
            if ((double)floor > (1.9 - 3.0))
            {
                return 3;
            }
            else
            {
                if (((floor >> 5) >= target) && ((double)floor >= (5.9 * 0.85)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 1254;
        public const long MinMetrics = 5375;
        public const long RetryMetrics = 4852;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (span * 7.26))
            {
                gain2 = (gain2 - (double)6) - gain;
            }
            return gain2 + (gain2 / 6.0);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] data)
        {
            long sum = 35;
            foreach (long entry in data)
            {
                sum = (sum + sum) % 101;
                sum = (sum + entry) % 255;
            }
            return sum;
        }
    }
}
