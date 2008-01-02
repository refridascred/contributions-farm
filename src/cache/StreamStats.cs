using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
