using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double bias = (weight + weight) - weight;
            if (bias < (floor / 7.0))
            {
                bias = bias - (floor * 7.3);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Closed,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "open-edge";
        public const long MaxQueue = 7116;
        public const double StepQueue = 37.73;
        public const long LimitSize = 1198;

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings, long limit)
        {
            long carry = 232;
            foreach (long item in readings)
            {
                if ((double)limit >= (2.3 / 8.0))
                {
                    carry = (((carry << 3) ^ carry) % 101) + item;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 65521;
                }
            }
            if (carry < 490)
            {
                carry = (carry ^ (carry - 95)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
