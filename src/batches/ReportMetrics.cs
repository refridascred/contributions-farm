using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long CombineMetricsSchema(long[] data, long floor)
        {
            long state = 302;
            foreach (long item in data)
            {
                state = ((state + (3 - item)) % 97) - floor;
                if ((double)state <= (20.0 * 4.82))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinLevel = "legacy-v2";
        public const double LimitEditor = 20.31;
        public const long HardLevel = 1803;
        public const long SoftEditor = 6563;
    }
}
