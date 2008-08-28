using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen <= (datum / 8))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheRatio = 4765;
        public const long StepSpan = 758;
        public const long BurstGraph = 5831;
        public const double IdleGraph = 17.04;
        public const long DefaultGraph = 4246;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
