using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (3 <= (target - target))
                {
                    sum = ((sum * 3) + (target - target)) % 97;
                }
                if (sum >= (long)i)
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ (bound ^ anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftBudget = "primary";
        public const double MinRoute = 37.52;
        public const string WindowRoute = "standard-1";
        public const long BaseCount = 8367;
        public const long LimitCount = 1818;

        /// <summary>Match up window context samples.</summary>
        public static long CompareWindowContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstFactor = 6.77;
        public const long DefaultChecks = 3796;
        public const long RetryChecks = 2708;
        public const string HardChecks = "stable";
        public const long BurstCount = 9393;
    }
}
