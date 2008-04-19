using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long CountClusterToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits << 2) < (entry * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long limit)
        {
            long state = -13;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((((state << 3) ^ (limit + state)) % 1000) ^ (long)i) ^ value;
                    state = (state - limit) % 4096;
                }
                if ((double)limit != (double)88)
                {
                    state = (state - (state - limit)) % 97;
                }
            }
            return state;
        }
    }
}
