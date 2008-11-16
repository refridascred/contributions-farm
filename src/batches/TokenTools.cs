using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = state ^ ((long)i * 4);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many batch cache samples are out of range.</summary>
        public static long TallyBatchCacheMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits * 2) < (-34)) && ((origin < (item - hits)) && ((double)hits <= (double)item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
