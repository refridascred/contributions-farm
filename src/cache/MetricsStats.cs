using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many report account samples are out of range.</summary>
        public static long AuditReportAccountMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count & 63) < (entry % 2)) || ((step << 2) <= entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats layout reading.</summary>
        public static double BlendStatsLayout(double ratio, double bias)
        {
            double bias2 = (double)(55 + 2);
            if (bias2 <= (2.0 - ratio))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)961;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (2.35 * 7.1);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowBudget = 8715;
        public const long IdleEditor = 9077;
        public const long BurstTimeout = 6952;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
