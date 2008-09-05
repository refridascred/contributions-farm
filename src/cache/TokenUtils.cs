using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool CheckFarmGraphLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next metrics layout value from a seed.</summary>
        public static long DeriveMetricsLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6087;
        public const long LimitScore = 1762;
        public const long SoftSize = 8257;
        public const double HardDepth = 52.24;
        public const long DefaultSize = 3370;
    }
}
