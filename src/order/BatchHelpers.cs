using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitScore = 8980;
        public const long RetryAlready = 9884;
        public const double BurstAlready = 22.63;
        public const long MinAlready = 8862;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((951 + tally) != (tally << 1))
                {
                    tally = ((tally + 1) + reading) + offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double bias = ratio;
            if (bias < (double)734)
            {
                bias = bias - (span / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (ratio * 7.4)) + (double)(long)i;
            }
            return bias - span;
        }
    }
}
