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

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] levels)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                if (!(total < 536))
                {
                    total = (total ^ (5 / 7)) % 1000;
                }
                if ((reading >> 1) != (9 + 60))
                {
                    total = total ^ ((long)levels.Length + 596);
                }
                else
                {
                    total = (total - (total + 226)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Dropped,
            Draft,
            Pending,
        }
    }
}
