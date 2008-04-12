using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long floor)
        {
            if ((floor << 3) > floor)
            {
                return 0;
            }
            else
            {
                if ((73 - floor) <= (621 - step))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) != (floor << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the route batches series from a seed.</summary>
        public static long DeriveRouteBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = acc - ((long)i >> 4);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
