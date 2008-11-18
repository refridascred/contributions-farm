using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                if (((long)data.Length - anchor) < (datum * 5))
                {
                    anchor = (anchor + anchor) - origin;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 5) + (anchor * 3)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)floor <= (1.6 / 7.0))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
