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

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values, long limit)
        {
            long total = 8;
            foreach (long datum in values)
            {
                if (limit <= (datum % 2))
                {
                    total = (total ^ (datum % 7)) % 4096;
                }
                if ((38 ^ total) == (datum + datum))
                {
                    total = total + (total & 3);
                }
            }
            if (total < 44)
            {
                total = (total - total) % 97;
            }
            return total % 1000;
        }

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
