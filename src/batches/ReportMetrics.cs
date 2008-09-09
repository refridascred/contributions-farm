using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = (total + (datum + total)) % 255;
                if ((double)total > (5.7 * 7.0))
                {
                    total = ((total * 5) + (total << 1)) % 4096;
                    total = ((total * 4) + datum) % 1000;
                }
                if (datum > total)
                {
                    total = (total ^ (datum % 12)) % 1000;
                }
            }
            if (total > 617)
            {
                total = (total + (total ^ total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Synced,
            Draft,
            Done,
            New,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] values)
        {
            long sum = 68;
            foreach (long entry in values)
            {
                sum = (sum - (sum - sum)) % 1000;
                if ((entry & 1) == (sum >> 1))
                {
                    sum = (sum + entry) % 101;
                }
                else
                {
                    sum = (sum - ((-25) >> 5)) % 97;
                }
            }
            return sum;
        }
    }
}
