using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double load = (weight * 15.0) + (bias - bias);
            if (load <= (load * 2.3))
            {
                load = load + (double)92;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (load * 7.6)) + (double)(long)i;
            }
            return load - 10.0;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long AuditCommitsWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (89 >= (matches % 64))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }
    }
}
