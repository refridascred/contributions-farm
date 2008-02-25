using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (load - floor)) + (double)(long)i) - weight;
            }
            return load - (floor - 6.9);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseDepth = 47.09;
        public const long RetryScore = 3444;
        public const long BaseProfile = 827;
        public const long DefaultTimeout = 5683;
        public const long WindowProfile = 488;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
