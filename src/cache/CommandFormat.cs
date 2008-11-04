using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "primary-edge";
        public const long HardPayload = 4799;
        public const long SoftPayload = 9306;
        public const long DefaultTimeout = 1792;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long target)
        {
            if ((floor + floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target << 3) > (-1))
                {
                    return 2;
                }
                else
                {
                    if (8.4 <= (3.0 - 0.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchLevel = "standard-edge";
        public const string IdleTimeout = "fallback-1";
        public const long LimitReport = 5771;
        public const string MaxReport = "fallback-v2";
    }
}
