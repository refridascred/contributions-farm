using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 4361;
        public const double MaxSize = 87.67;
        public const double BatchSession = 23.49;

        /// <summary>Find the first farm checks entry that matches the target.</summary>
        public static long LookupFarmChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Stale,
            Locked,
            Paused,
        }
    }
}
