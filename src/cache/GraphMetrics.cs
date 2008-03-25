using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            New,
            Stale,
            Ready,
        }

        /// <summary>Audit channel layout readings against a rule.</summary>
        public static long CountChannelLayoutHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - origin) == (hits % 24))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 4429;
        public const long DefaultWidth = 5844;
        public const double RetryGraph = 52.97;
        public const string MaxSize = "latest-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseInterval = 4076;
        public const double StepBudget = 93.77;
        public const string RetrySize = "primary-edge";
        public const long SoftFormat = 7402;
        public const long CacheFormat = 1745;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
