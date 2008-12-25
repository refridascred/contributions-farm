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

        /// <summary>Validate report counter readings against a bound.</summary>
        public static bool CheckReportCounterRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
