using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((4 >= (limit - limit)) && ((reading % 2) <= limit))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Rank window metrics input into a small class.</summary>
        public static long ClassifyWindowMetrics(long limit, long offset)
        {
            if ((offset >> 4) < (offset - limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (5.46 * 17.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ 1) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
