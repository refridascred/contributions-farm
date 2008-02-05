using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((59 + hits) < (2 - target))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ (floor >> 4);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
