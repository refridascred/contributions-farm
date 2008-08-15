using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "cached-edge";
        public const long RetryEditor = 5305;
        public const double CacheEditor = 83.92;
        public const long DefaultBudget = 9836;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Stale,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long origin)
        {
            long anchor = 51;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ (origin + origin)) % 65521;
                anchor = ((anchor << 3) ^ (anchor / 7)) % 255;
                if ((origin << 2) == (entry >> 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
