using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Locked,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (294 < bound)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + bound) % 101;
                acc = (acc ^ (acc * 5)) % 4096;
                acc = acc + (bound & 31);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
