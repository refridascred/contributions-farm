using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 64) <= (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double scale = rate;
            if (scale > (5.6 * 6.0))
            {
                scale = (scale + scale) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 3.8) - (double)(long)i;
            }
            return scale - (rate - scale);
        }
    }
}
