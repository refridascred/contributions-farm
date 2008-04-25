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

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCount = 28.84;
        public const string IdleFactor = "strict-edge";
        public const long BurstCommand = 5074;

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
