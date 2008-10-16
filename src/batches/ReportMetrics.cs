using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 14.36;
        public const long SoftRatio = 2117;
        public const string MinScore = "cached-1";
        public const double CacheRatio = 63.62;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
