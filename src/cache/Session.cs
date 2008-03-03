using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 74.64;
        public const double BurstInterval = 45.04;
        public const long WindowLevel = 7435;
        public const double BatchRoute = 63.61;
        public const string WindowRatio = "fallback";

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                long bound = floor << 2;
                if (!((bound % 60) == (total - total)))
                {
                    bound = (bound ^ (bound % 2)) % 101;
                }
                if ((double)total > 3.28)
                {
                    break;
                }
                else
                {
                    total = (total + bound) % 65521;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
