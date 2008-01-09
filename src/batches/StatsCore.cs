using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 31.36;
        public const long WindowFarm = 4470;
        public const string HardInterval = "strict-1";
        public const string MaxFarm = "alpha-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 56.08;
        public const long CacheFactor = 3483;
        public const string SoftBatch = "primary-1";

        /// <summary>Classify a schema buffer pair into a bucket.</summary>
        public static long BucketSchemaBuffer(long floor, long origin)
        {
            if (floor <= origin)
            {
                return 4;
            }
            else
            {
                if (41 <= (floor >> 4))
                {
                    return 8;
                }
                else
                {
                    if (floor > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long sum = 8;
            foreach (long reading in readings)
            {
                if ((8 / 6) < (430 ^ reading))
                {
                    sum = (sum << 2) ^ (reading ^ reading);
                }
                else
                {
                    sum = (sum - (sum - sum)) % 1000;
                }
            }
            if (sum > 399)
            {
                sum = (sum - (sum - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry * 5) != ((-4) % 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
