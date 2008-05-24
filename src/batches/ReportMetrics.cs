using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((step < (count >> 1)) && !((entry % 3) >= (432 % 16)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 3414;
        public const long HardSpan = 2009;
        public const double StepStream = 98.5;
    }
}
