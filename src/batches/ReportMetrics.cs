using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4581;
        public const double StepPayload = 39.83;
        public const long CacheLevel = 6884;

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
