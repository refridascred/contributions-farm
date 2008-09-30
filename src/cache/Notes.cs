using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Idle,
            Failed,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 6611;
        public const long SoftLevel = 1033;
        public const long BaseContext = 823;
        public const long CacheContext = 1956;

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples, long origin)
        {
            long state = -9;
            foreach (long datum in samples)
            {
                state = state - (datum - state);
                if ((origin * 3) < (datum % 64))
                {
                    break;
                }
            }
            return state;
        }
    }
}
