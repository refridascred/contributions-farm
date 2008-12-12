using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings)
        {
            long acc = 81;
            foreach (long value in readings)
            {
                if (acc >= (value & 3))
                {
                    acc = acc - (value + value);
                }
            }
            if (acc > 264)
            {
                acc = (acc + (acc + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Synced,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long SortEntryAlready(long origin, long target)
        {
            if ((target / 2) > target)
            {
                return 1;
            }
            else
            {
                if (((-889) + origin) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
