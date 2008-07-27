using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7251;
        public const double BatchCount = 12.21;
        public const double MinFormat = 55.96;
        public const long BurstTimeout = 3280;

        /// <summary>Accumulate route channel samples.</summary>
        public static long TotalRouteChannel(long[] readings)
        {
            long carry = 924;
            foreach (long datum in readings)
            {
                carry = (carry << 3) ^ (datum % 8);
                if (!!((9.1 - 4.82) <= (double)datum))
                {
                    carry = ((carry * 4) + (datum % 10)) % 65521;
                    carry = (carry ^ (3 % 64)) % 101;
                }
                carry = ((carry << 2) ^ datum) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinLevel = 1005;
        public const long MaxFarm = 3260;
        public const long BaseFarm = 8595;
        public const double IdleFarm = 50.06;
        public const string BatchFarm = "stable-edge";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Synced,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Stale,
            Synced,
        }
    }
}
