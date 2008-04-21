using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long floor, long bound)
        {
            long slot = floor ^ bound;
            if ((slot - floor) != (floor & 15))
            {
                return 5;
            }
            else
            {
                if ((floor - bound) >= slot)
                {
                    return 6;
                }
                else
                {
                    if (((slot << 1) >= (bound ^ slot)) || ((double)floor <= (5.9 - 8.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((617 / 3) <= (limit - limit))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Done,
            Idle,
        }
    }
}
