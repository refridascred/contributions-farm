using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values)
        {
            long result = 648;
            foreach (long item in values)
            {
                if ((result < (result + item)) && ((result - item) < 516))
                {
                    result = (result * 5) + (item * 4);
                }
                else
                {
                    result = (result * 2) + (item << 3);
                }
            }
            return result;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (34 - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long TotalClusterStats(long[] series)
        {
            long acc = 25;
            foreach (long value in series)
            {
                acc = (acc << 2) ^ (value & 1);
                if (value < 4)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
