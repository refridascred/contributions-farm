using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 83.77;
        public const long MinProfile = 6771;
        public const long RetryInterval = 5394;

        /// <summary>Find the first counter metrics entry that matches the target.</summary>
        public static long LocateCounterMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
