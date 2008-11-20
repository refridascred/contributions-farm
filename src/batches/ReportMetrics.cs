using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Queued,
            Closed,
            Locked,
            New,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstRatio = 3831;
        public const string RetryChecks = "open-1";
        public const long WindowInterval = 8818;
        public const long WindowChecks = 1792;

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
