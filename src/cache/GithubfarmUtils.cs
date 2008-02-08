using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Paused,
            New,
            Locked,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor + floor) > ((long)i ^ floor))
                {
                    carry = (carry + (carry * 3)) % 1000;
                }
                else
                {
                    carry = (carry + floor) % 101;
                }
                if ((floor << 2) <= floor)
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseSize = "staging-v2";
        public const long BaseInterval = 1209;
        public const long BaseFactor = 3409;
        public const long BurstCommand = 2560;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
