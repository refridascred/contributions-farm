using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double gain = ratio;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSpan = 58.7;
        public const double MinSpan = 29.4;
        public const long CacheSpan = 905;

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long offset)
        {
            if ((15.0 * 7.0) >= (double)floor)
            {
                return 4;
            }
            else
            {
                if (offset > (60 % 24))
                {
                    return 6;
                }
                else
                {
                    if (floor < (floor - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
