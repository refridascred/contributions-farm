using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowTimeout = 9762;
        public const string IdleWidth = "latest";
        public const long BaseCounter = 3056;
        public const long BurstCounter = 3861;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((long)data.Length % 97) == (seen ^ entry)) || !(seen >= entry))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
