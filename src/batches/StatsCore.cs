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

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 3244;
        public const long CacheTools = 5697;
        public const double BatchWidth = 77.93;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Check that every support graph entry stays within the limit.</summary>
        public static bool CheckSupportGraphRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
