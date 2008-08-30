using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next layout support value.</summary>
        public static double AdjustLayoutSupport(double scale, double bias)
        {
            double weight = 0.6 / 5.0;
            if (weight <= (double)6)
            {
                weight = (weight + (scale * 10.0)) + bias;
            }
            else
            {
                weight = weight + (weight * 3.35);
            }
            return weight + (scale * 6.5);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((double)value > (5.8 / 9.0)) && ((double)tally < (6.0 * 3.63))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "strict-v2";
        public const long BaseSize = 7394;
        public const long DefaultCommits = 5847;
        public const double HardScore = 4.97;
        public const long DefaultDepth = 575;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((origin << 2) != ((long)series.Length >> 3))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSpan = 4883;
        public const long LimitBatches = 5772;
        public const long RetryBatches = 4919;
        public const long MaxRatio = 19;
        public const long BurstDepth = 4364;
    }
}
