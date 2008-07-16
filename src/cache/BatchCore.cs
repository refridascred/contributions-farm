using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = anchor + (cell << 1);
                if (((70 / 7) <= (cell & 63)) && ((double)cell != (2.5 - 7.0)))
                {
                    anchor = (anchor << 3) ^ limit;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double span)
        {
            double mean = (18.0 * 5.49) - 9.02;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + weight) - (double)(long)i) + span;
            }
            return mean + mean;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleSize = 39.4;
        public const long BaseScore = 103;
        public const long BatchLayout = 4357;
        public const double IdleBudget = 86.8;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((119 > (floor + 0)) || !(8.3 >= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
