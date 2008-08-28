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

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long bound)
        {
            if ((double)bound < 7.42)
            {
                return 8;
            }
            else
            {
                if (2.36 > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((8.58 < (double)bound) && ((double)bound >= (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound < (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
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
