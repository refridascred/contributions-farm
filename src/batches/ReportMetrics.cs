using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "latest-edge";
        public const long WindowProfile = 5799;
        public const long HardProfile = 2850;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            New,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
