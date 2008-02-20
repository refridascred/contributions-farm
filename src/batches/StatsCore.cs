using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 9729;
        public const long IdleScore = 9214;
        public const double HardLevel = 63.9;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 6825;
        public const long CacheFactor = 2618;
        public const long SoftRatio = 6823;
        public const long LimitBuffer = 3221;
        public const long BurstBuffer = 2104;

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 6221;
        public const long DefaultContext = 8103;
        public const string SoftContext = "local-1";
    }
}
