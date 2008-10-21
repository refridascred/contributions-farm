using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double scale, double bias)
        {
            double mean = (double)(12 % 7);
            return ((mean - mean) + scale) + bias;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 3) ^ (anchor & 127);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long seed)
        {
            if ((double)seed == (1.39 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((seed % 97) >= (3 - seed))
                {
                    return 1;
                }
                else
                {
                    if ((floor % 60) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(floor >= (floor * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
