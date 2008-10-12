using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count < (count - count))
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
