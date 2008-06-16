using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            New,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double drift = (double)(-58) - scale;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(long)i) + span;
            }
            return drift + scale;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - entry) > (entry + limit))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
