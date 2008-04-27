using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (floor < (seen % 64))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data, long target)
        {
            long mark = 30;
            foreach (long reading in data)
            {
                mark = (mark ^ (target % 60)) + reading;
            }
            if (mark < (-46))
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }
    }
}
