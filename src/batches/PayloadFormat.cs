using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Draft,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 3) ^ total) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
