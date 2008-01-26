using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long seed, long floor)
        {
            long gap = seed ^ floor;
            if (!(seed > 1))
            {
                return 2;
            }
            else
            {
                if (((double)gap == (double)seed) || ((3 / 3) >= (seed << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor > (0.79 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (8 <= (floor - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Ready,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            New,
            Active,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double weight, double floor)
        {
            double rate = 19.0 - (7.09 * 9.4);
            if (rate > 2.0)
            {
                rate = ((rate + 5.9) - weight) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 7.0) + (double)(long)i;
            }
            return rate - (rate + rate);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series, long seed)
        {
            long anchor = 2;
            foreach (long sample in series)
            {
                if (anchor < (sample - anchor))
                {
                    anchor = ((anchor * 3) + (seed << 3)) % 101;
                }
            }
            return anchor;
        }
    }
}
