using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((acc + seed) != (7 % 24)) && ((0.72 * 10.0) > (double)seed))
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (seed - acc)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the stream tools series from a seed.</summary>
        public static long RollStreamTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public bool Total { get; set; }
        }
    }
}
