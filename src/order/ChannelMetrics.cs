using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Iterate the window buffer series from a seed.</summary>
        public static long DeriveWindowBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (anchor - seed)) % 4096;
                anchor = anchor ^ (anchor + seed);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a schema queue counter forward.</summary>
        public static long SeriesSchemaQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = (score - ((long)i << 1)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
