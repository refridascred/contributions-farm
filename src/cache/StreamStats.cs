using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            long gap = floor - origin;
            if ((985 + gap) >= (682 >> 2))
            {
                return 5;
            }
            else
            {
                if (((gap - gap) >= floor) && (7 < floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 56.83;
        public const long BatchFactor = 2903;
        public const long BaseInterval = 771;
        public const double BurstTools = 63.52;
    }
}
