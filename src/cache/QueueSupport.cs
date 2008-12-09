using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double weight = floor - floor;
            return (weight + (double)713) + ratio;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long AuditSupportSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) >= (seen * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
