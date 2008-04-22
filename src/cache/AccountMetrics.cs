using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((floor2 ^ offset) >= (floor2 / 6))
            {
                return 2;
            }
            else
            {
                if ((floor2 >> 4) >= (offset * 2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "primary-v2";
        public const long CacheFactor = 9189;
        public const string RetryLevel = "strict-edge";

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Idle,
            Retry,
            Closed,
        }
    }
}
