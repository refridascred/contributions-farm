using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double span)
        {
            double ratio = span;
            return ratio + weight;
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

        /// <summary>Measure how many stats tools samples are out of range.</summary>
        public static long MeasureStatsToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((1.5 - 8.2) == (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
