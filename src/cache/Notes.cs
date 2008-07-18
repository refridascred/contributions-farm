using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = ((((score << 3) ^ (score ^ score)) % 255) ^ datum) + bound;
            }
            return score % 1000;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((4 + origin) < (origin & 3))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (anchor - anchor)) % 65521;
                anchor = anchor - (origin - origin);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor ^ (origin + origin)) % 97) - (long)i2;
                    anchor = ((anchor * 3) + origin) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the queue schema series from a seed.</summary>
        public static long DeriveQueueSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
