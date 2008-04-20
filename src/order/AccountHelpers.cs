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

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleCount = 31.52;
        public const string LimitFactor = "strict-v2";
        public const long RetryAccount = 8305;
        public const long HardAccount = 3074;
    }
}
