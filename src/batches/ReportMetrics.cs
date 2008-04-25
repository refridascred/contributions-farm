using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Ready,
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxSpan = 70.87;
        public const long IdleBudget = 4565;
        public const long StepFactor = 3147;
        public const long BatchFactor = 1386;
        public const long StepRoute = 7936;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data)
        {
            long anchor = 290;
            foreach (long value in data)
            {
                if (anchor <= (value >> 1))
                {
                    anchor = anchor + (anchor + value);
                }
            }
            return anchor % 65521;
        }
    }
}
