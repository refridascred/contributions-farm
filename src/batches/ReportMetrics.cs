using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Dropped,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long MeasureFormatGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - seen) > seen)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
