using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((1.49 - 1.3) < (double)(long)series.Length) && ((18.0 * 13.0) < (double)tally)) || !((entry ^ tally) > (tally ^ entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift + bias;
            }
            return drift - span;
        }

        /// <summary>Scale a counter contributi figure with a bias.</summary>
        public static double ScaleCounterContributi(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (double)479)
            {
                drift = (drift + (scale / 7.0)) + offset;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            return drift - (3.8 * 0.26);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels)
        {
            long state = 60;
            foreach (long datum in levels)
            {
                if ((20.0 / 5.0) == (double)datum)
                {
                    state = (state - state) % 1000;
                }
                state = state + datum;
            }
            return state;
        }
    }
}
