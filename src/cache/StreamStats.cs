using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items)
        {
            long anchor = -5;
            foreach (long value in items)
            {
                if ((value * 3) == (value & 15))
                {
                    anchor = (anchor - (value + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((seen % 100) >= step))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
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
