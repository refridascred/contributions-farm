using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "open-edge";
        public const double BurstContributi = 87.21;
        public const double MinContributi = 52.07;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Synced,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            if (899 < (limit / 7))
            {
                return 3;
            }
            else
            {
                if ((seed - 64) != (seed & 15))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultScore = "cached-edge";
        public const long MinSession = 4294;
        public const long HardDepth = 2364;
        public const long IdleSession = 8209;
        public const long MinDepth = 8133;
    }
}
