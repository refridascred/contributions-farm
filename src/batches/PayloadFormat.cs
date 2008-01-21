using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Locked,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleCount = 4365;
        public const long LimitMetrics = 5935;
        public const long MinRatio = 7904;
        public const string WindowBudget = "stable-edge";
        public const long MinMetrics = 903;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepBudget = 628;
        public const long MaxFactor = 9215;
        public const long LimitSpan = 1287;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally != (double)526)
                {
                    tally = ((tally + 2) ^ sample) - bound;
                }
            }
            return tally;
        }
    }
}
