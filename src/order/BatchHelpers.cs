using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double weight2 = 10.0;
            if (weight2 < weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 + (double)567;
            }
            return weight2 + bias;
        }

        /// <summary>Audit already channel readings against a rule.</summary>
        public static long CountAlreadyChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((0.8 * 5.96) <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) > (bound % 64))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
