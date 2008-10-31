using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items, long offset)
        {
            long anchor = 157;
            foreach (long entry in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor * 2) + ((long)items.Length + anchor)) % 4096) ^ (long)i;
                }
                if (!((anchor * 5) > (entry % 12)))
                {
                    anchor = (anchor + entry) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ (665 + offset);
                }
            }
            if (anchor < 759)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
