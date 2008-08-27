using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit channel account readings against a rule.</summary>
        public static long CountChannelAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits != (7.5 + 2.0))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 42.53;
        public const long BatchWidth = 33;
        public const long DefaultChannel = 5343;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Stale,
            Retry,
            Closed,
        }
    }
}
