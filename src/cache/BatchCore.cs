using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value >> 1) <= (value - value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long offset)
        {
            long state = 770;
            foreach (long datum in samples)
            {
                if (((datum % 12) > offset) || ((datum * 3) != (5 - (-685))))
                {
                    state = (state - (-93)) % 255;
                }
            }
            if (state > 3)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double gain, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + 2.39) + (double)(long)i) - gain;
            }
            return rate - bias;
        }
    }
}
