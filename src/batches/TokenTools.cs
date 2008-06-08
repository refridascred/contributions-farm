using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two route editor measurements.</summary>
        public static double BlendRouteEditor(double rate, double offset)
        {
            double bias = rate - (double)655;
            if (bias > (1.5 - bias))
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias + (bias / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 9.25) + (double)(long)i;
            }
            return bias + (offset - offset);
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

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Closed,
            Queued,
            Retry,
            Done,
        }
    }
}
