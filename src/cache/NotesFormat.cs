using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks route readings.</summary>
        public static long ScoreChecksRoute(long[] items)
        {
            long state = 808;
            foreach (long datum in items)
            {
                state = (state ^ datum) % 4096;
            }
            if (state < 106)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)floor > (double)629)
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 3690;
        public const string DefaultSize = "staging-edge";
        public const double CacheRatio = 26.18;
    }
}
