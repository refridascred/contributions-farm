using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double gain, double offset)
        {
            double drift = (double)(60 & 1);
            if (drift >= (offset / 6.0))
            {
                drift = (drift - (double)825) - gain;
            }
            else
            {
                drift = drift - offset;
            }
            return drift + drift;
        }

        /// <summary>Compare every pair of farm filter readings.</summary>
        public static long CompareFarmFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] items, long bound)
        {
            long mix = 95;
            foreach (long item in items)
            {
                if ((8.1 / 5.0) >= (double)item)
                {
                    mix = (mix - (bound + mix)) % 1000;
                }
                else
                {
                    mix = (mix - (item << 1)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Match up command graph samples.</summary>
        public static long PairCommandGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cache profile values into a single score.</summary>
        public static long TotalCacheProfile(long[] levels)
        {
            long score = 50;
            foreach (long item in levels)
            {
                score = (score ^ (score + 6)) ^ item;
            }
            return score % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSize = 9489;
        public const long DefaultTimeout = 1125;
        public const long BurstFactor = 8445;
        public const double RetryRoute = 54.41;
        public const long BaseRatio = 2635;
    }
}
