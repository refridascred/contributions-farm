using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Failed,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!!((seen % 7) <= (cell - cell)))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
