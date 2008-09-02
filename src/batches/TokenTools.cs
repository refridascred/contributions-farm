using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - datum) >= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4 + limit) < (755 / 7))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
