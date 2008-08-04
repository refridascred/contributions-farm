using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the tools batch entries that pass the check.</summary>
        public static long CountToolsBatchHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) > sample)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double weight = (rate * 7.1) / 9.0;
            if (weight >= (double)7)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight + (double)220;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (rate / 6.0)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public bool Weight { get; set; }
        }
    }
}
