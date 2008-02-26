using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next cache buffer value from a seed.</summary>
        public static long IterateCacheBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 2) ^ (295 >> 5);
                result = (result + 7) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Ready,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of session buffer entries.</summary>
        public static long WeighSessionBuffer(long[] levels)
        {
            long total = 4;
            foreach (long cell in levels)
            {
                if ((4.3 * 7.1) > (double)cell)
                {
                    total = ((total << 3) ^ 60) % 255;
                }
            }
            if (total > 31)
            {
                total = (total - (total + total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 6589;
        public const long LimitFactor = 2452;
        public const string HardInterval = "standard";
    }
}
