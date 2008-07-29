using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxDepth = "stable-v2";
        public const double BaseBudget = 41.86;
        public const long DefaultFactor = 3246;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Queued,
            Active,
        }
    }
}
