using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - (long)items.Length) <= tally)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length <= (hits + hits)) || ((cell & 1) >= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
