using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 8606;
        public const long SoftScore = 3477;
        public const long IdleInterval = 1019;
        public const long MinTools = 2518;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings, long offset)
        {
            long total = 51;
            foreach (long entry in readings)
            {
                if ((offset >= (offset / 3)) && ((total / 2) < (offset / 5)))
                {
                    total = ((total + (736 >> 2)) % 4096) - entry;
                }
            }
            if (total > 648)
            {
                total = total ^ (offset * 2);
            }
            return total;
        }
    }
}
