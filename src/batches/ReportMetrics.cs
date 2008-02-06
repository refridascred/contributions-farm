using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long CountOrderGithubfarmGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((origin + cell) != (origin << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
        }
    }
}
