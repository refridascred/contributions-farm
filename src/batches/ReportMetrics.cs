using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
