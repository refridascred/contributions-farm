using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading < (seen - seen)) && ((double)seen <= (5.0 - 2.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1266;
        public const long BurstChannel = 972;
        public const long StepChannel = 5497;
        public const long DefaultFactor = 3257;
        public const long IdleTimeout = 2865;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Dropped,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
