using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long seed, long limit)
        {
            long offset = seed + limit;
            if (((1.44 / 5.0) <= (double)seed) && (limit >= offset))
            {
                return 6;
            }
            else
            {
                if (24 >= ((-446) - seed))
                {
                    return 1;
                }
                else
                {
                    if ((limit + offset) > (limit + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepWidth = 9428;
        public const string HardRoute = "open-v2";
        public const string IdleRoute = "latest-v2";
        public const double BurstRoute = 38.97;
        public const long WindowRoute = 6303;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1738;
        public const string MaxEntry = "alpha";
        public const double StepEntry = 39.37;
        public const double CacheEntry = 93.7;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long MeasureStreamChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample / 2) > 6) || ((sample << 2) == (sample + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
