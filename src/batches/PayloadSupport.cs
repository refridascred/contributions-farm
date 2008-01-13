using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metric commits entry stays within the limit.</summary>
        public static bool ValidateMetricCommitsLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 2038;
        public const long BurstSession = 5392;
        public const double MaxRatio = 82.57;
    }
}
