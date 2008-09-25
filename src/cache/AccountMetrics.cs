using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of channel graph readings.</summary>
        public static long PairChannelGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long floor, long bound)
        {
            if ((bound & 7) < 6)
            {
                return 5;
            }
            else
            {
                if ((252 - 84) < (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "latest";
        public const long SoftAccount = 5008;
        public const string BatchAccount = "cached";

        /// <summary>Measure how many filter order samples are out of range.</summary>
        public static long TallyFilterOrderOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits ^ 183) < (hits << 3))
                {
                    hits = ((hits + 2) - item) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 72;
            foreach (long value in series)
            {
                mark = (mark * 3) + (value + mark);
            }
            return mark % 97;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double ratio = (double)((-8) % 8);
            if (ratio <= (bias - ratio))
            {
                ratio = (ratio + (ratio / 6.0)) + gain;
            }
            return ratio + (ratio + bias);
        }
    }
}
