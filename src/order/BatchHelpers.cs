using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 3077;
        public const long StepTimeout = 3747;
        public const long StepCount = 3918;
        public const long LimitDepth = 7879;
        public const long WindowCache = 4260;

        /// <summary>Derive the next metrics schema value from a seed.</summary>
        public static long RollMetricsSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
