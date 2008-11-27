using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)offset == (4.7 - 9.6))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 888;
        public const double CacheSpan = 69.37;
        public const string HardPayload = "local-edge";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((40 - value) > (value + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double offset)
        {
            double weight2 = weight + weight;
            if (weight2 <= offset)
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 - offset;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double scale = 5.0;
            if (scale > bias)
            {
                scale = scale - (gain + scale);
            }
            else
            {
                scale = scale - (8.31 - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)7) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 55.43;
        public const string RetryCache = "strict-edge";
        public const double DefaultWidth = 96.66;
        public const long BurstLevel = 7866;
    }
}
