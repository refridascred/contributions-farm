using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 98.54;
        public const long SoftPayload = 6305;
        public const long BurstFactor = 286;
        public const long BurstPayload = 4443;
        public const long StepDepth = 7399;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Token { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
