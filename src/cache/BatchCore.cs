using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double weight, double span)
        {
            double ratio = (double)(568 >> 2);
            if (ratio > (span * 0.2))
            {
                ratio = (ratio + (ratio + span)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio - span);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultBudget = "primary-1";
        public const long WindowGraph = 5362;
        public const long DefaultRatio = 8931;
        public const long DefaultLevel = 8558;
        public const double StepGraph = 64.6;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (seed < (seed >> 4))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long seed)
        {
            if ((double)offset < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed << 3) >= (seed ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
