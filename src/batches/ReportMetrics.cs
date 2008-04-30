using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Scale a context report figure with a bias.</summary>
        public static double SmoothContextReport(double rate, double span)
        {
            double weight = (double)((-94) >> 1);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + rate) + (double)(long)i) + span;
            }
            return weight + (rate * 7.7);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((sample % 3) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
