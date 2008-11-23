using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of window cache readings.</summary>
        public static long TotalWindowCache(long[] data)
        {
            long acc = 276;
            foreach (long cell in data)
            {
                acc = (acc - (acc ^ cell)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
