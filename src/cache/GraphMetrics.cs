using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long origin)
        {
            if (!((2.5 - 2.42) >= (double)origin))
            {
                return 8;
            }
            else
            {
                if ((origin < (seed + seed)) && ((75 - origin) >= (origin % 3)))
                {
                    return 2;
                }
                else
                {
                    if (((seed - seed) == (62 % 16)) || ((seed * 4) != (origin << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5527;
        public const long BaseTimeout = 4955;
        public const double BurstDepth = 22.4;
        public const long BurstSupport = 7939;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
