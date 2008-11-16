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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >= (seed + 98)) && ((8 * 5) < (entry + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
