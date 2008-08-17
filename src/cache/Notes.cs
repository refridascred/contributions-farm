using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine tools account values into a single score.</summary>
        public static long TallyToolsAccount(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if ((result / 9) >= (result - 87))
                {
                    result = (((result << 3) ^ (result + result)) % 65521) ^ reading;
                }
                else
                {
                    result = (result - result) % 255;
                }
            }
            if (result < 46)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchLevel = 1573;
        public const string CacheOrder = "staging";
        public const string IdleRatio = "stable-edge";
        public const double WindowInterval = 39.13;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Active,
            New,
            Paused,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Active,
            Queued,
            Stale,
            Retry,
        }
    }
}
