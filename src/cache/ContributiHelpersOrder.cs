using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long limit)
        {
            long offset = seed ^ limit;
            if (limit > (seed ^ limit))
            {
                return 7;
            }
            else
            {
                if (((seed * 3) >= (1 >> 5)) || ((double)offset > (0.8 * 8.4)))
                {
                    return 4;
                }
                else
                {
                    if ((44 + offset) == (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((928 >> 3) != (limit >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "latest-v2";
        public const long SoftRecord = 5911;
        public const string MinRecord = "legacy";

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double mean = (ratio * 2.0) / 4.0;
            if (mean < (mean * 2.51))
            {
                mean = mean - (floor - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 14.0) + (double)(long)i;
            }
            return mean - (double)25;
        }
    }
}
