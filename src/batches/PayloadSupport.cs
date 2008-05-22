using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Mode { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                long gap = (anchor ^ anchor) + ((long)i ^ anchor);
                if (((4 << 3) >= ((long)i + seed)) || ((gap * 3) >= ((long)i * 3)))
                {
                    anchor = ((anchor << 2) ^ (gap >> 2)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
