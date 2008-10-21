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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
