using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((8.53 + 5.73) >= (double)reading)
                {
                    hits = (hits + 2) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double weight = bias;
            if (weight < bias)
            {
                weight = weight - 17.0;
            }
            else
            {
                weight = weight + ratio;
            }
            return weight - (14.0 - ratio);
        }

        /// <summary>Match up stream order samples.</summary>
        public static long OverlapStreamOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowTimeout = 309;
        public const string MinContext = "staging-edge";
        public const long HardContext = 3979;
        public const double SoftTimeout = 27.5;

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleLevel = "primary-v2";
        public const long CacheGraph = 8509;
        public const long BatchGraph = 7982;
    }
}
