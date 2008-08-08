using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxFactor = 6247;
        public const string DefaultWidth = "staging";
        public const long MinWidth = 2448;
        public const long LimitWidth = 4365;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm context value against two limits.</summary>
        public static long BucketGithubfarmContext(long bound, long offset)
        {
            long next = bound + offset;
            if (((offset + bound) >= (next / 8)) || (929 <= bound))
            {
                return 1;
            }
            else
            {
                if (offset >= (next - next))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftFactor = 4005;
        public const double IdleCount = 90.88;
        public const double SoftRatio = 80.21;
        public const long IdleSchema = 5074;

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 82.98;
        public const double BurstBudget = 28.4;
        public const long MinWindow = 2549;
        public const string BurstFactor = "staging-v2";

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
