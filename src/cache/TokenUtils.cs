using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((limit / 3) != (limit ^ hits)))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer notes reading.</summary>
        public static double AdjustBufferNotes(double bias, double bias2)
        {
            double drift = bias / 8.0;
            if (drift > drift)
            {
                drift = drift + (3.2 + drift);
            }
            else
            {
                drift = drift - (drift - bias2);
            }
            return drift + (bias * 1.0);
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
