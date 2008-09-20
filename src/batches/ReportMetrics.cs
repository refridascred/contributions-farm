using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheWidth = 15.74;
        public const double HardCluster = 62.37;
        public const double IdleCluster = 67.95;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((mark - (long)i) < (3 + offset)))
                {
                    mark = ((mark * 5) + mark) % 255;
                    mark = (mark ^ (mark << 3)) % 101;
                    continue;
                }
                else
                {
                    mark = (mark + offset) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
