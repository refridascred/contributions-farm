using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many graph entry samples are out of range.</summary>
        public static long CountGraphEntryHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + 92) <= (origin << 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSize = "stable";
        public const string SoftProfile = "latest-v2";
        public const long RetryProfile = 2077;
        public const string WindowProfile = "standard-v2";

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }
    }
}
