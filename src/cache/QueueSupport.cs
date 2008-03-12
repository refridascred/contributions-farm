using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryDepth = 4845;
        public const long MinCounter = 6145;
        public const long BatchCounter = 1718;

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
