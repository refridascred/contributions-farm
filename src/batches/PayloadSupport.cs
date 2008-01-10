using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a commits channel counter forward.</summary>
        public static long StepCommitsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a support cache reading by value.</summary>
        public static long LocateSupportCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
