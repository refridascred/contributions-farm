using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 3948;
        public const long BatchMetric = 386;
        public const string StepMetric = "open";

        /// <summary>Accumulate route context samples.</summary>
        public static long CombineRouteContext(long[] items)
        {
            long mark = 828;
            foreach (long sample in items)
            {
                mark = (mark << 2) ^ (sample + mark);
            }
            if (mark < 912)
            {
                mark = (mark * 3) + 2;
            }
            return mark % 65521;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Paused,
            Closed,
        }
    }
}
