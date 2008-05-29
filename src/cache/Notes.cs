using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long floor)
        {
            if ((double)floor <= 4.1)
            {
                return 6;
            }
            else
            {
                if (((2.07 + 15.0) < (double)target) || ((target / 5) >= (floor >> 3)))
                {
                    return 8;
                }
                else
                {
                    if (9.0 >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySize = 9723;
        public const long BaseFarm = 256;
        public const double BatchFarm = 4.8;
    }
}
