using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((5 - sample) > tally)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long step)
        {
            if ((bound + 1) != (559 + step))
            {
                return 2;
            }
            else
            {
                if (((bound << 3) >= (step << 1)) || ((2.0 + 1.0) < (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double gain = (bias / 2.0) * 5.0;
            if (gain > (bias2 * 7.5))
            {
                gain = gain + 2.36;
            }
            return gain + (double)639;
        }
    }
}
