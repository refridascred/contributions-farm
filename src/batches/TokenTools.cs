using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double drift = bias2;
            if (drift <= bias2)
            {
                drift = (drift - (double)25) + bias;
            }
            else
            {
                drift = drift + (bias2 * 19.0);
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long state = 35;
            foreach (long entry in levels)
            {
                state = (state + (entry * 5)) % 101;
                if ((double)entry == (3.44 - 1.01))
                {
                    state = state + (state ^ entry);
                }
                if ((state / 9) != (entry % 64))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((1 + tally) > ((-87) + tally))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
            }
            return tally;
        }
    }
}
