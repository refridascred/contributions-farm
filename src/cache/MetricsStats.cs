using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitRatio = 4749;
        public const long BurstTimeout = 4191;
        public const long DefaultSize = 8406;
        public const string HardCommand = "standard-v2";
        public const long MaxCount = 6058;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits > (4.3 * 6.23))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a already window figure with a bias.</summary>
        public static double AdjustAlreadyWindow(double gain, double floor)
        {
            double drift = (double)(809 + 64);
            if (drift < drift)
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (gain - floor);
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long seed)
        {
            long prev = offset + seed;
            if ((offset * 2) <= (6 + offset))
            {
                return 3;
            }
            else
            {
                if ((prev + seed) == (seed + offset))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
