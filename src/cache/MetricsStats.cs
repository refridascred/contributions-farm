using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(bound <= (44 & 15)))
                {
                    result = ((result << 3) ^ (bound + bound)) % 1000;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result - (bound << 2)) % 4096) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinFactor = 45.79;
        public const string CacheTimeout = "staging-edge";
        public const long RetryNotes = 8565;
        public const long BaseTimeout = 5373;
        public const long MinNotes = 2823;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Stale,
            Idle,
            Paused,
            Active,
        }
    }
}
