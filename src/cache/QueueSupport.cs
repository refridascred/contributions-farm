using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowRatio = "open";
        public const long BurstProfile = 2539;
        public const long BaseProfile = 4027;
        public const long WindowBudget = 9922;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (double)hits)
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
