using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryFactor = 56.3;
        public const double RetryCommits = 52.11;
        public const long LimitCommits = 3861;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long floor, long floor2)
        {
            long edge = floor + floor2;
            if (floor > (floor2 + floor))
            {
                return 8;
            }
            else
            {
                if ((floor - edge) != (7 + floor2))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 & 255) >= (floor - edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
