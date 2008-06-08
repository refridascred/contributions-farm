using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values, long bound)
        {
            long anchor = -319;
            foreach (long entry in values)
            {
                if (bound < (entry - entry))
                {
                    anchor = ((anchor << 2) ^ (entry + bound)) % 65521;
                }
                else
                {
                    anchor = (anchor + entry) % 4096;
                }
            }
            if (anchor < 36)
            {
                anchor = ((anchor << 3) ^ (21 - anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((-290) & 63) >= limit)
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Failed,
            Dropped,
        }
    }
}
