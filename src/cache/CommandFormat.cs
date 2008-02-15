using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Pending,
            New,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long seed)
        {
            long delta = floor + seed;
            if ((delta - delta) >= (floor >> 3))
            {
                return 6;
            }
            else
            {
                if ((floor >= (seed * 3)) && ((double)floor > (5.0 + 6.8)))
                {
                    return 1;
                }
                else
                {
                    if (((17.0 * 2.93) != (double)floor) || ((double)floor <= (8.68 - 18.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
