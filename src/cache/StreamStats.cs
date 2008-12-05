using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a graph cluster counter forward.</summary>
        public static long IterateGraphCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 2) ^ (275 % 7)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
