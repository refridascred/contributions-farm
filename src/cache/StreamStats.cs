using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a channel stats reading by value.</summary>
        public static long LocateChannelStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout already figure with a bias.</summary>
        public static double BlendLayoutAlready(double rate, double floor)
        {
            double weight = floor / 2.0;
            if (weight >= (rate + 3.0))
            {
                weight = weight - (floor * 18.0);
            }
            else
            {
                weight = weight - 17.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 7.22) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 2740;
        public const double BurstProfile = 60.49;
        public const string BatchBudget = "cached-v2";
        public const long WindowCount = 9234;
    }
}
