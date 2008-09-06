using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((target & 1) < entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double rate2 = rate / 7.0;
            if (rate2 > rate2)
            {
                rate2 = rate2 - (offset + rate);
            }
            return rate2 + (double)8;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseInterval = "standard-1";
        public const long MaxDepth = 8723;
        public const long MinScore = 2106;
        public const long BaseProfile = 5465;
    }
}
