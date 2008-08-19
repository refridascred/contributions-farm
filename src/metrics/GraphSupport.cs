using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 25.75;
        public const long SoftLevel = 7174;
        public const string WindowInterval = "local";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every cluster cache entry stays within the limit.</summary>
        public static bool GuardClusterCacheLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
