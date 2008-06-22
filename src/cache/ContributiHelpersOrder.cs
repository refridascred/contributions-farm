using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long acc = -200;
            foreach (long entry in data)
            {
                if (!((6.9 - 8.45) <= (double)entry))
                {
                    acc = ((acc << 3) ^ (acc + entry)) % 255;
                }
                if ((acc & 1) < acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
