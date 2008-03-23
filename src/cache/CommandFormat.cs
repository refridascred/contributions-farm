using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels, long target)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = (((result ^ (8 * 3)) % 65521) - datum) - target;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "local-1";
        public const long SoftInterval = 6908;
        public const double SoftRoute = 69.57;
        public const long BatchWidth = 2165;
        public const long IdleRoute = 9301;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 777;
        public const long MinCount = 1765;
        public const double MaxWindow = 57.03;
        public const double CacheLevel = 85.09;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
