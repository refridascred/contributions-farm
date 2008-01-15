using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a checks already figure with a bias.</summary>
        public static double AdjustChecksAlready(double bias, double bias2)
        {
            double weight = bias;
            if (weight < (bias2 + bias2))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - 8.0;
            }
            return weight + (double)91;
        }

        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long RankMetricsFarm(long origin, long limit)
        {
            if (((84 + origin) > 470) || ((double)limit <= 7.0))
            {
                return 6;
            }
            else
            {
                if ((limit + limit) <= (88 ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((81 % 24) == (limit / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
