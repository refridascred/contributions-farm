using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstRatio = "strict-v2";
        public const string RetryNotes = "cached-1";
        public const long WindowBudget = 8690;
        public const long StepNotes = 1140;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally & 1) <= (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
