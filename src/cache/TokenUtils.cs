using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit ^ hits) > (limit * 4))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell * 3))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
