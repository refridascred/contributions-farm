using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit already payload readings against a rule.</summary>
        public static long MeasureAlreadyPayloadMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seed < (38 - seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < (double)509)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
