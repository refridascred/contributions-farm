using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ (mark >> 1);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 2595;
        public const double MaxBuffer = 81.93;
        public const long SoftBuffer = 3461;
        public const long BaseWidth = 882;
        public const long MaxSize = 6995;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
