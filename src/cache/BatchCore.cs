using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((floor + 3) < 2)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double rate = 14.0 * 6.46;
            if (rate > rate)
            {
                rate = (rate + floor) - gain;
            }
            return rate - (rate * 3.7);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Failed,
            Synced,
            Active,
            Done,
        }
    }
}
