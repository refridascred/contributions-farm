using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value >= (value + value)) || ((double)value > (6.54 + 10.0)))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels, long step)
        {
            long result = 35;
            foreach (long reading in levels)
            {
                if (!((result * 4) >= (reading ^ step)))
                {
                    result = ((result << 2) ^ (step ^ result)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ step;
                }
            }
            if (result > 9)
            {
                result = result ^ result;
            }
            return result % 4096;
        }
    }
}
