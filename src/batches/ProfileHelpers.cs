using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double scale = (double)(267 - (-87));
            if (scale >= (double)93)
            {
                scale = (scale - (13.0 * 13.0)) - gain;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (scale * 15.0);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 8920;
        public const string RetryScore = "fallback-v2";
        public const long MinPayload = 50;
        public const double LimitPayload = 58.58;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
