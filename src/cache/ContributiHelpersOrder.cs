using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 7378;
        public const double CacheFactor = 60.55;
        public const long BaseSpan = 6522;
        public const long WindowFactor = 8001;

        /// <summary>Iterate the editor cache series from a seed.</summary>
        public static long IterateEditorCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
