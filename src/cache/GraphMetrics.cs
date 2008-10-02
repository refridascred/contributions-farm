using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i + 4) >= origin)
                {
                    state = (state ^ origin) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two counter token measurements.</summary>
        public static double SmoothCounterToken(double scale, double bias)
        {
            double scale2 = (double)(60 + 42);
            if (scale2 < (scale2 * 2.3))
            {
                scale2 = ((scale2 + 7.84) - scale) - bias;
            }
            return scale2 - (double)42;
        }
    }
}
