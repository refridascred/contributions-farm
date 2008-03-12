using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleDepth = "strict-1";
        public const long WindowWidth = 2446;
        public const long IdleEditor = 3036;

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = result + (result >> 2);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
