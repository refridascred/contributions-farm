using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Active,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftDepth = 96.27;
        public const long HardMetrics = 8042;
        public const long SoftWidth = 5705;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values, long seed)
        {
            long acc = -2;
            foreach (long cell in values)
            {
                if ((seed + seed) != (cell >> 1))
                {
                    acc = (acc - ((-665) % 100)) % 4096;
                }
                else
                {
                    acc = (acc - (cell % 97)) % 101;
                }
                if ((cell - cell) <= (acc - seed))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double ratio, double bias)
        {
            double weight = (double)7 - ratio;
            if (weight < 7.2)
            {
                weight = weight - ratio;
            }
            return weight - bias;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
