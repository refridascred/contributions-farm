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

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double bias2 = (double)(-43) / 5.0;
            if (bias2 >= (bias2 + bias2))
            {
                bias2 = (bias2 + floor) - bias;
            }
            return bias2 + (double)1;
        }
    }
}
