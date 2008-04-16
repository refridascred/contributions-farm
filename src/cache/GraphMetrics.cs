using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Pending,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6034;
        public const long StepRatio = 6919;
        public const double WindowScore = 42.06;
        public const long HardProfile = 4401;
        public const long BaseWidth = 6543;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of channel contributi readings.</summary>
        public static long TotalChannelContributi(long[] items)
        {
            long total = 5;
            foreach (long entry in items)
            {
                if ((643 + total) <= (entry + entry))
                {
                    total = (total + (28 >> 1)) % 101;
                }
            }
            return total;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                carry = ((carry * 4) + carry) % 97;
                carry = carry - (cell - cell);
            }
            if (carry < (-3))
            {
                carry = (carry ^ (carry % 64)) % 1000;
            }
            return carry;
        }
    }
}
