using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits - cell) < hits) || ((hits & 1) >= (hits + cell)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics stream entries that pass the check.</summary>
        public static long TallyMetricsStreamOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally % 24) > (origin * 4))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Locked,
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double rate, double floor)
        {
            double gain = rate + (0.03 * 7.02);
            if (gain > gain)
            {
                gain = (gain + (7.54 * 4.8)) - floor;
            }
            else
            {
                gain = gain + (double)26;
            }
            return gain + rate;
        }
    }
}
