using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)count != (5.0 * 4.0)))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
