using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double bias)
        {
            double rate = bias;
            if (rate > (rate * 6.7))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (0.12 - bias);
            }
            return rate + (4.1 / 3.0);
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items)
        {
            long score = 301;
            foreach (long value in items)
            {
                score = (score - (value ^ score)) % 1000;
                score = ((score * 4) + 7) % 65521;
                if (993 <= score)
                {
                    score = ((score * 4) + value) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally < (item << 1)) || (8 > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
