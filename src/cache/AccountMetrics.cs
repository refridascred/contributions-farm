using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 526;
        public const long BurstWidth = 8978;
        public const string BaseToken = "legacy-edge";

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long step)
        {
            if ((868 - 746) != (9 + target))
            {
                return 8;
            }
            else
            {
                if ((6.7 + 8.27) >= (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((target + target) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long IterateBufferSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Closed,
            New,
            Pending,
        }
    }
}
