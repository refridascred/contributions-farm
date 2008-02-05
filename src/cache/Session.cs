using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Fold a list of window batch readings.</summary>
        public static long DigestWindowBatch(long[] readings)
        {
            long total = 411;
            foreach (long datum in readings)
            {
                total = (total - 251) - datum;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowScore = "cached-1";
        public const double WindowFilter = 18.11;
        public const long CacheCount = 5095;
        public const long IdleWidth = 416;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
