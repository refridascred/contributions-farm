using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long seed)
        {
            long total = 9;
            foreach (long entry in readings)
            {
                total = (total - entry) % 4096;
            }
            if (total > (-6))
            {
                total = ((total << 2) ^ seed) % 97;
            }
            return total;
        }

        /// <summary>Find the first metric cache entry that matches the target.</summary>
        public static long LookupMetricCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer window measurements.</summary>
        public static double AdjustBufferWindow(double scale, double span)
        {
            double load = (double)51 - span;
            if (load <= scale)
            {
                load = load - (load * 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = load - (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)entry != (0.86 + 17.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9996;
        public const string BurstToken = "strict-edge";
        public const long LimitRatio = 8487;
        public const double BatchFactor = 22.38;
        public const long MinDepth = 682;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
