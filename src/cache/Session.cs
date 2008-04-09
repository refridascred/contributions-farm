using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long floor)
        {
            long anchor = 34;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 2) + (cell & 127)) - floor;
                if ((double)cell > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Synced,
            Failed,
            Done,
            Dropped,
        }
    }
}
