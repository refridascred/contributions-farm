using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - count) <= (value * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if (((mix + 86) < (value / 7)) && ((17.0 * 8.0) >= (double)mix))
                {
                    mix = (mix ^ (mix * 3)) % 97;
                }
                else
                {
                    mix = (mix ^ 22) % 1000;
                }
            }
            return mix;
        }
    }
}
