using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Dropped,
            Stale,
            Done,
        }
    }
}
