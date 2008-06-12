using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((0.3 / 3.0) < (double)matches)
                {
                    matches = ((matches + 2) + item) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double bias)
        {
            double weight = bias + gain;
            if (weight < weight)
            {
                weight = weight - (double)7;
            }
            else
            {
                weight = weight + bias;
            }
            return weight + gain;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((limit + 80) == (sample % 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
