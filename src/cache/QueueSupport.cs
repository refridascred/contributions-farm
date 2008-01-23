using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((origin - origin) >= (origin << 3)) || ((75 ^ hits) <= (-57)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepSize = 17.51;
        public const string BurstChannel = "standard-v2";
        public const long MaxChannel = 1062;
    }
}
