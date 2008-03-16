using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cluster context readings against a rule.</summary>
        public static long CountClusterContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum * 4) < (datum / 6))
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

        /// <summary>Iterate the context batches series from a seed.</summary>
        public static long IterateContextBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
