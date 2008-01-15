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

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double floor)
        {
            double drift = 1.0;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - gain) + (double)(long)i) + floor;
            }
            return drift - 3.0;
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
