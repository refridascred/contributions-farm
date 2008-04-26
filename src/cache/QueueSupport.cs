using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two report record measurements.</summary>
        public static double ProjectReportRecord(double scale, double span)
        {
            double weight = scale;
            if (weight >= (weight / 3.0))
            {
                weight = (weight - weight) - span;
            }
            return weight - (weight - scale);
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (4 <= (item + hits))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
