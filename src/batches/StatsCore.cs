using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a window cache reading by value.</summary>
        public static long LookupWindowCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstScore = 8965;
        public const double IdleEntry = 91.26;
        public const double IdleDepth = 44.28;

        /// <summary>Adjust a cluster already reading.</summary>
        public static double AdjustClusterAlready(double scale, double span)
        {
            double gain = span;
            if (gain >= (double)17)
            {
                gain = gain + (scale + 3.7);
            }
            else
            {
                gain = gain + (span - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (gain * 0.42);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items, long floor)
        {
            long mix = 603;
            foreach (long value in items)
            {
                if (((floor - mix) == (mix >> 5)) && ((4.41 - 16.0) != (double)value))
                {
                    mix = (mix - (228 >> 2)) % 255;
                }
            }
            if (mix > 671)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}
