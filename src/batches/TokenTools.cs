using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 63.9;
        public const long MaxStream = 9114;
        public const long CacheStream = 8288;
        public const double DefaultStream = 91.54;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
