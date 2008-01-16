using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Paused,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((count << 3) <= count) && ((reading << 3) >= (count >> 4))) || ((count + reading) > reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6288;
        public const string BaseTimeout = "strict-edge";
        public const string BurstBudget = "staging";
        public const long BatchBuffer = 4141;
    }
}
