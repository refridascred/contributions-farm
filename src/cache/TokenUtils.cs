using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up record queue samples.</summary>
        public static long PairRecordQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate metric farm readings against a bound.</summary>
        public static bool ValidateMetricFarmBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double ratio = floor - weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (floor / 9.0)) + (double)(long)i;
            }
            return ratio - (weight * 19.0);
        }
    }
}
