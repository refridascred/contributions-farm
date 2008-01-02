using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings)
        {
            long anchor = 32;
            foreach (long sample in readings)
            {
                if (!((sample - anchor) >= anchor))
                {
                    anchor = anchor ^ (anchor - anchor);
                    continue;
                }
                if ((1.8 - 0.18) >= (double)anchor)
                {
                    anchor = (anchor ^ (anchor << 3)) % 4096;
                }
            }
            return anchor % 4096;
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
