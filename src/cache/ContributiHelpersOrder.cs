using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double scale, double floor)
        {
            double bias = (double)(720 % 5);
            return ((bias - bias) + scale) + floor;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long target, long bound)
        {
            if (!((453 - target) != (bound * 4)))
            {
                return 2;
            }
            else
            {
                if (bound < (bound + target))
                {
                    return 8;
                }
                else
                {
                    if ((2 + target) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long target)
        {
            long mark = 1;
            foreach (long entry in data)
            {
                if ((double)target <= (9.8 * 8.0))
                {
                    mark = mark ^ (entry & 127);
                }
            }
            return mark % 97;
        }
    }
}
